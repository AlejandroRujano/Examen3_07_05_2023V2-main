using ExamenDockUp.Properties;
using Newtonsoft.Json;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace ExamenDockUp
{
    public partial class FormFactura : Form
    {
        private string _path = "";
        private string _pathDatosEmpresa = "";
        private string _pathProductos = "";
        private double _subtotal = 0;
        private double _impuesto = 0;
        private int _retencion = 0;
        private double _total = 0;
        private string _codigo = "";
        private Usuario _vendedor = new Usuario();
        private List<Productos> _productosDisponibles = new List<Productos>();
        private List<Productos> _productosListaOriginal = new List<Productos>();
        private List<Productos> _compras = new List<Productos>();
        private List<Factura> _facturas = new List<Factura>();
        private List<string> _datosEmpresa = new List<string>();
        private Cliente _cliente = new Cliente();
        private DataGridView _dataPreview = new DataGridView();
        private ComboBox _cbClientes = new ComboBox();
        private Label _lblprecio = new Label();
        private Label _lblprecioTotal = new Label();
        private SaveFileDialog guardar = new SaveFileDialog();
        public FormFactura()
        {
            InitializeComponent();
        }
        public double Impuesto { get { return _impuesto; } set { _impuesto = value; } }
        public int Retencion { get { return _retencion; } set { _retencion = value; } }
        public double Total { get { return _total; } set { _total = value; } }
        public double SubTotal { get { return _subtotal; } set { _subtotal = value; } }
        public List<Factura> Facturas { get { return _facturas; } set { _facturas = value; } }
        public List<Productos> ProductosOriginales { get { return _productosListaOriginal; } set { _productosListaOriginal = value; } }
        public List<Productos> ProductosDisponibles { get { return _productosDisponibles; } set { _productosDisponibles = value; } }
        public Cliente Cliente { get { return _cliente; } set { _cliente = value; } }
        public List<string> DatosEmpresa { get { return _datosEmpresa; } set { _datosEmpresa = value; } }
        public Usuario Vendedor { get { return _vendedor; } set { _vendedor = value; } }
        public List<Productos> Compras { get { return _compras; } set { _compras = value; } }
        public string PathDatosEmpresa { get { return _pathDatosEmpresa; } set { _pathDatosEmpresa = value; } }
        public string PathProductos { get { return _pathProductos; } set { _pathProductos = value; } }
        public string Path { get { return _path; } set { _path = value; } }
        public DataGridView DataPreview { get { return _dataPreview; } set { _dataPreview = value; } }
        public ComboBox CBClientes { get { return _cbClientes; } set { _cbClientes = value; } }
        public Label lblPrecio { get { return _lblprecio; } set { _lblprecio = value; } }
        public Label lblPrecioTotal { get { return _lblprecioTotal; } set { _lblprecioTotal = value; } }
        private void GuardarFactura()
        {
            string jsonFacturas = JsonConvert.SerializeObject(_facturas.ToArray(), Formatting.Indented);
            System.IO.File.WriteAllText(_path, jsonFacturas);
        }
        private void GuardarProductos()
        {
            string jsonProductos = JsonConvert.SerializeObject(_productosListaOriginal.ToArray(), Formatting.Indented);
            System.IO.File.WriteAllText(_pathProductos, jsonProductos);
        }
        
        /*private void DescontarInventario()
        {
            for(int i=0; i<_productosDisponibles.Count; i++)
            {
                for(int j=0; j<_compras.Count; j++)
                {
                    if (_compras[j].Codigo == _productosDisponibles[i].Codigo)
                    {
                        _productosDisponibles[i].Cantidad -= _compras[j].Cantidad;
                    }
                }
            }
        }*/

        private void LlenarDatosDeFactura()
        {
            _codigo = ((_facturas.Count + 1).ToString()).PadLeft(5, '0');
            lblNumeroFactura.Text = $"Factura N°  {_codigo}";
            lblFecha.Text = $"Fecha de Emision:  {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
            lblHora.Text = $"{DateTime.Now.ToString("hh:mm:ss tt")}";

            lblNombreEmpresa.Text = DatosEmpresa[0];
            lblCorreoElectronico.Text = $"E-Mail: {DatosEmpresa[1]}";
            lblRif.Text = $"Rif: {DatosEmpresa[2]}";
            rtbDireccionEmpresa.Text = $"{DatosEmpresa[3]}";

            lblNombreVendedor.Text = $"{_vendedor.Nombre} {_vendedor.Apellido}";
            lblCedulaVendedor.Text = $"V{_vendedor.Cedula}";
            lblNombreComprador.Text = $"{_cliente.Nombre} {_cliente.Apellido}";
            lblCedulaComprador.Text = $"{_cliente.Cedula}";
            lblTelefonoComprador.Text = $"{_cliente.NumeroDeTlf}";
        }
        private void LlenarTablaDeCompras()
        {
            dgvProductos.Rows.Clear();
            dgvImpuestos.Rows.Clear();
            dgvProductos.Rows.Add(_compras.Count);
            dgvImpuestos.Rows.Add(4);
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                for (int j = 0; j < dgvProductos.Columns.Count; j++)
                {
                    if (j == 0) dgvProductos[j, i].Value = _compras[i].Cantidad;
                    else if (j == 1) dgvProductos[j, i].Value = _compras[i].Data_Codigo();
                    else if (j == 2) dgvProductos[j, i].Value = _compras[i].Precio;
                    else if (j == 3) dgvProductos[j, i].Value = _compras[i].Precio * _compras[i].Cantidad;
                }
            }
            dgvImpuestos[0, 0].Value = "SubTotal:";
            dgvImpuestos[0, 1].Value = "Iva 16%:";
            dgvImpuestos[0, 2].Value = $"Retencion {_retencion}%:";
            dgvImpuestos[0, 3].Value = "Total";
            dgvImpuestos[1, 0].Value = _subtotal;
            dgvImpuestos[1, 1].Value = _impuesto;
            dgvImpuestos[1, 2].Value = (_impuesto * _retencion) / 100;
            if (Convert.ToInt32(dgvImpuestos[1, 2].Value) == 0) dgvImpuestos[1, 3].Value = _total;
            else dgvImpuestos[1, 3].Value = _total - Convert.ToInt32(dgvImpuestos[1, 2].Value);
        }
        private void FormFactura_Load(object sender, EventArgs e)
        {
            //LeerListaDeFacturas();
            LlenarDatosDeFactura();
            LlenarTablaDeCompras();
            dgvTotalImpuestos();
        }
        private void dgvTotalImpuestos()
        {
            if (dgvImpuestos.Rows.Count == 0)
            {
                dgvImpuestos.Rows.Add(3);
                dgvImpuestos.Rows[0].Cells[0].Value = "SubTotal";
                dgvImpuestos.Rows[1].Cells[0].Value = "Iva 16%";
                dgvImpuestos.Rows[2].Cells[0].Value = "Monto Total";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<string> _datosVendedor = new List<string>
            {
                _vendedor.Nombre,
                _vendedor.Apellido,
                _vendedor.Cedula
            };

            //Cuando unda aceptar en la parte de facturar, se guarda la factura, se limpia el carrito
            //se limpia la tabla, etc...

            if(DialogResult.Yes == MessageBox.Show("Desea Guardar la Factura en Formato PDF?", "Facturacion en PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                if(checkDireccion.Checked == true)
                {
                    //MessageBox.Show("Aqui se llama a la funcion de hacer PDF con Checkbox");
                    GenerarPDF($"{_datosEmpresa[4]}"+$"\\Factura_{_codigo}_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.pdf");
                }
                else
                {
                    //MessageBox.Show("Aqui se llama a la funcion de hacer PDF Normal");
                    if (DireccionGuardarPDF() == DialogResult.OK)
                    {
                        GenerarPDF(guardar.FileName);
                    }
                }
            }
            
            _facturas.Add(new Factura(lblFecha.Text, _datosEmpresa, _codigo, _compras, _cliente, _datosVendedor, _total, _impuesto));
            GuardarFactura();
            GuardarProductos();

            _compras.Clear();
            _dataPreview.Rows.Clear();
            _cbClientes.SelectedIndex = -1;
            _cbClientes.Text = "Seleccionar";
            _lblprecio.Text = "0";
            _lblprecioTotal.Text = "0";
            this.Close();
        }

        //Funcion que abre una ventana y pregunta donde desea guardar el PDF
        //Esta Funcion es utilizada si la persona desmarca el Checkbox
        //Por tanto se entiende que no quier guardar el PDF en la direccion preestablecida
        private DialogResult DireccionGuardarPDF()
        {
            guardar.Filter = "Archivo PDF (.pdf)|.pdf";
            guardar.Title = "Guardar como";
            guardar.FileName = $"Factura_{_codigo}_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}";
            return guardar.ShowDialog();
        }

        //Boton para Buscar y guardar la Direccion Preestablecida
        private void btnDireccionGuardar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DireccionParaGuardar = new FolderBrowserDialog();
            DireccionParaGuardar.Description = "Direccion Preestablecida para Guardar Facturas";

            if (DireccionParaGuardar.ShowDialog() == DialogResult.OK)
            {
                if(_datosEmpresa.Count == 4)
                {
                    _datosEmpresa.Add(DireccionParaGuardar.SelectedPath);
                }
                else
                {
                    _datosEmpresa[4] = DireccionParaGuardar.SelectedPath;
                }

                string DatosEmpresaJson = JsonConvert.SerializeObject(_datosEmpresa.ToArray(), Formatting.Indented);
                System.IO.File.WriteAllText(_pathDatosEmpresa, DatosEmpresaJson);
            }
        }

        //CheckBox De Direccion Preestablecida
        private void checkDireccion_Click(object sender, EventArgs e)
        {
            if (_datosEmpresa.Count == 4)
            {
                MessageBox.Show("Para poder habilitar la presente opcion\nPrimero debe Establecer una Direccion\ncon el boton ubicado debajo de este", "Es Necesario Indicar una direccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (checkDireccion.Checked == true) checkDireccion.Checked = false;
                else checkDireccion.Checked = true;
            }
        }
        #region GenerarPDFDefinitivo
        
        private void GenerarPDF(string pathPDF)
        {
                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.MarginHorizontal(20);
                        page.MarginVertical(35);

                        page.Header().ShowOnce().Row(row =>
                        {


                            //byte[] imagedata = File.ReadAllBytes("BackgroundLogo.jpg");

                            //row.ConstantItem(140).Height(60).MaxWidth(5, Unit.Centimetre).Image(imagedata);

                            Resources.Logo.Save("BackgroundLogo.jpg");

                            byte[] imagedata = System.IO.File.ReadAllBytes("BackgroundLogo.jpg");

                            row.RelativeItem().MaxWidth(1, Unit.Centimetre).Width(180).Height(45).Image(imagedata,ImageScaling.Resize);

                            //row.ConstantItem(140).Height(60).Placeholder();


                            row.RelativeItem().Column(col =>
                            {
                                col.Item().AlignCenter().Text($"{DatosEmpresa[0]}").Bold().FontSize(14);
                                col.Item().AlignCenter().Text($"{DatosEmpresa[3]}").FontSize(10);
                                col.Item().AlignCenter().Text($"RIF: {DatosEmpresa[2]}").FontSize(9);
                                col.Item().AlignCenter().Text($"E-Mail: {DatosEmpresa[1]}").FontSize(9);

                            });
                            row.RelativeItem().PaddingHorizontal(8).Column(col =>
                            {
                                col.Item().Border(1).BorderColor("#ADD8E6").AlignCenter().Text($"Factura N° {_codigo}");
                                col.Item().Background("#ADD8E6").Border(1).BorderColor("#ADD8E6").AlignCenter().Text($"Fecha de Emision:  {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}").FontColor("#fff").FontSize(10);
                                col.Item().Background("#ADD8E6").Border(1).BorderColor("#ADD8E6").AlignCenter().Text($"{ DateTime.Now.ToString("hh:mm:ss tt")}").FontColor("#fff").FontSize(10);
                            });

                        });
                        page.Content().Padding(10).Column(Contenido =>
                        {
                            Contenido.Item().PaddingVertical(20).Row(row1 =>
                            {
                                row1.RelativeItem().AlignLeft().Column(col1 =>
                                {
                                    col1.Item().Text("Datos del Cliente").Underline().Bold();

                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Nombre: ").SemiBold().FontSize(10);
                                        txt.Span($"{_cliente.Nombre} {_cliente.Apellido}").FontSize(10);
                                    });

                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Cedula: ").SemiBold().FontSize(10);
                                        txt.Span($"{_cliente.Cedula}").FontSize(10);
                                    });

                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Numero de Telefono: ").SemiBold().FontSize(10);
                                        txt.Span($"{_cliente.NumeroDeTlf}").FontSize(10);
                                    });

                                });

                                row1.RelativeItem().AlignRight().Column(col1 =>
                                {
                                    col1.Item().Text("Datos del Vendedor").Underline().Bold();
                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Nombre: ").SemiBold().FontSize(10);
                                        txt.Span($"{_vendedor.Nombre} {_vendedor.Apellido}").FontSize(10);
                                    });

                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Cedula: ").SemiBold().FontSize(10);
                                        txt.Span($"V{_vendedor.Cedula}").FontSize(10);
                                    });
                                });
                            });
                            Contenido.Item().PaddingTop(20).Border(1, Unit.Point).Table(TablaProductos =>
                            {
                                TablaProductos.ColumnsDefinition(Columnas =>
                                {
                                    Columnas.RelativeColumn(Convert.ToSingle(0.75));
                                    Columnas.RelativeColumn(Convert.ToSingle(1.75));
                                    Columnas.RelativeColumn();
                                    Columnas.RelativeColumn();
                                });

                                TablaProductos.Header(_header =>
                                {
                                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Cantidad").Black();
                                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Producto").Black();
                                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Precio Unitario").Black();
                                    _header.Cell().Padding(4, Unit.Point).AlignCenter().Text("Precio Total").Black();
                                });

                                foreach (DataGridViewRow Fila in dgvProductos.Rows)
                                {
                                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(Fila.Cells["Cantidad"].Value.ToString());
                                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(Fila.Cells["Producto"].Value.ToString());
                                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(Fila.Cells["PrecioUnitario"].Value.ToString());
                                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(Fila.Cells["PrecioTotal"].Value.ToString());
                                }
                            });
                            Contenido.Item().Row(FilaTablaTotal =>
                            {
                                FilaTablaTotal.RelativeItem().Column(Labels =>
                                {
                                    Labels.Item().AlignCenter().AlignMiddle().PaddingTop(15).Text("ORIGINAL").ExtraLight().Italic().FontSize(10);
                                    Labels.Item().AlignCenter().AlignMiddle().PaddingTop(10).Text("Factura Emitida Sin Tachaduras").ExtraLight().Italic().FontSize(10);
                                    Labels.Item().AlignCenter().AlignMiddle().Text("ni Enmendaduras").ExtraLight().Italic().FontSize(10);
                                });
                                FilaTablaTotal.RelativeItem().Column(ColumnaTablaTotal =>
                                {
                                    ColumnaTablaTotal.Item().BorderLeft(1, Unit.Point).BorderRight(1, Unit.Point).BorderBottom(1, Unit.Point).Table(TablaTotal =>
                                    {
                                        TablaTotal.ColumnsDefinition(Columnas =>
                                        {
                                            Columnas.RelativeColumn();
                                            Columnas.RelativeColumn();
                                        });

                                        for (int i = 0; i < dgvImpuestos.Rows.Count; i++)
                                        {
                                            for (int j = 0; j < dgvImpuestos.Columns.Count; j++)
                                            {
                                                if (j / 1 == 0 && i == 3)
                                                {
                                                    TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).BorderRight(Convert.ToSingle(0.25), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(dgvImpuestos[j, i].Value.ToString()).Black();
                                                }
                                                else if (j / 1 == 0) TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).BorderRight(Convert.ToSingle(0.25), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(dgvImpuestos[j, i].Value.ToString());
                                                else TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).AlignCenter().Text(dgvImpuestos[j, i].Value.ToString());
                                            }
                                        }
                                    });
                                });
                            });
                        });
                    });
                });
                QuestPDF.Settings.License = LicenseType.Community;
                document.GeneratePdf(pathPDF);
        }
        #endregion
        
        #region GenerarPDFV1
        /*private void GenerarPDF()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
            guardar.Title = "Guardar como";
            guardar.FileName = $"Factura_{_codigo}_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}";

            if (guardar.ShowDialog()== DialogResult.OK)
            {
                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(20);

                        page.Header().Row(row =>
                        {
                            row.ConstantItem(140).Height(60).Placeholder();

                            row.RelativeItem().Column(col =>
                            {
                                col.Item().AlignCenter().Text($"{DatosEmpresa[0]}").Bold().FontSize(14);
                                col.Item().AlignCenter().Text($"{DatosEmpresa[3]}").FontSize(10);
                                col.Item().AlignCenter().Text($"RIF: {DatosEmpresa[2]}").FontSize(9);
                                col.Item().AlignCenter().Text($"E-mail: {DatosEmpresa[1]}").FontSize(9);

                            });
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Border(1).BorderColor("#ADD8E6").AlignCenter().Text($"Factura N•: {_codigo}");
                                col.Item().Background("#ADD8E6").Border(1).BorderColor("#ADD8E6").AlignCenter().Text($"{lblFecha.Text}").FontColor("#fff").FontSize(10);

                            });

                        });
                        page.Content().Padding(10).Column(Contenido =>
                        {
                            Contenido.Item().Padding(10).Row(row1 =>
                            {
                                row1.RelativeItem().AlignLeft().Column(col1 =>
                                {
                                    col1.Item().Text("Datos del Cliente").Underline().Bold();

                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Nombre: ").SemiBold().FontSize(10);
                                        txt.Span($"{_cliente.Nombre} {_cliente.Apellido}").FontSize(10);
                                    });

                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Cedula: ").SemiBold().FontSize(10);
                                        txt.Span($"{_cliente.Cedula}").FontSize(10);
                                    });

                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Numero de Telefono: ").SemiBold().FontSize(10);
                                        txt.Span($"{_cliente.NumeroDeTlf}").FontSize(10);
                                    });

                                });

                                row1.RelativeItem().AlignRight().Column(col1 =>
                                {
                                    col1.Item().Text("Datos del Vendedor").Underline().Bold();
                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Nombre: ").SemiBold().FontSize(10);
                                        txt.Span($"{_vendedor.Nombre} {_vendedor.Apellido}").FontSize(10);
                                    });

                                    col1.Item().Text(txt =>
                                    {
                                        txt.Span("Cedula: ").SemiBold().FontSize(10);
                                        txt.Span($"{_vendedor.Cedula}").FontSize(10);
                                    });
                                });
                            });
                            Contenido.Item().Border(1, Unit.Point).Table(TablaProductos =>
                            {
                                TablaProductos.ColumnsDefinition(Columnas =>
                                {
                                    Columnas.RelativeColumn();
                                    Columnas.RelativeColumn(Convert.ToSingle(1.5));
                                    Columnas.RelativeColumn();
                                    Columnas.RelativeColumn();
                                });

                                TablaProductos.Header(_header =>
                                {
                                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Cantidad").Black();
                                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Producto").Black();
                                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Precio Unitario").Black();
                                    _header.Cell().Padding(4, Unit.Point).AlignCenter().Text("Precio Total").Black();
                                });

                                foreach (DataGridViewRow Fila in dgvProductos.Rows)
                                {
                                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(Fila.Cells["Cantidad"].Value.ToString());
                                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(Fila.Cells["Producto"].Value.ToString());
                                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(Fila.Cells["PrecioUnitario"].Value.ToString());
                                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(Fila.Cells["PrecioTotal"].Value.ToString());
                                }
                            });
                            Contenido.Item().Row(FilaTablaTotal =>
                            {
                                FilaTablaTotal.RelativeItem().Column(Labels =>
                                {
                                    Labels.Item().AlignCenter().AlignMiddle().PaddingTop(15).Text("ORIGINAL").ExtraLight().Italic().FontSize(10);
                                    Labels.Item().AlignCenter().AlignMiddle().PaddingTop(10).Text("Factura Emitida Sin Tachaduras").ExtraLight().Italic().FontSize(10);
                                    Labels.Item().AlignCenter().AlignMiddle().Text("ni Enmendaduras").ExtraLight().Italic().FontSize(10);
                                });
                                FilaTablaTotal.RelativeItem().Column(ColumnaTablaTotal =>
                                {
                                    ColumnaTablaTotal.Item().BorderLeft(1, Unit.Point).BorderRight(1, Unit.Point).BorderBottom(1, Unit.Point).Table(TablaTotal =>
                                    {
                                        TablaTotal.ColumnsDefinition(Columnas =>
                                        {
                                            Columnas.RelativeColumn();
                                            Columnas.RelativeColumn();
                                        });

                                        for (int i = 0; i < dgvImpuestos.Rows.Count; i++)
                                        {
                                            for (int j = 0; j < dgvImpuestos.Columns.Count; j++)
                                            {
                                                if (j / 1 == 0 && i == 3)
                                                {
                                                    TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).BorderRight(Convert.ToSingle(0.25), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(dgvImpuestos[j, i].Value.ToString()).Black();
                                                }
                                                else if(j / 1 == 0) TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).BorderRight(Convert.ToSingle(0.25), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).Text(dgvImpuestos[j, i].Value.ToString());
                                                else TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).PaddingHorizontal(10, Unit.Point).PaddingVertical(2, Unit.Point).AlignCenter().Text(dgvImpuestos[j, i].Value.ToString());
                                            }
                                        }
                                    });
                                });
                            });
                        });
                        /*
                        Contenido.Item().AlignRight().BorderLeft(1, Unit.Point).BorderRight(1, Unit.Point).BorderBottom(1, Unit.Point).Table(TablaTotal =>
                        {
                            TablaTotal.ColumnsDefinition(Columnas =>
                            {
                                Columnas.RelativeColumn();
                                Columnas.RelativeColumn();
                            });

                            for (int i = 0; i < dgvImpuestos.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvImpuestos.Columns.Count; j++)
                                {
                                    TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(dgvImpuestos[j, i].Value.ToString());
                                }
                            }
                        });*/

        /*page.Content().PaddingTop(10).Element(ContainerTablaProductos =>
        {
            ContainerTablaProductos.Border(1, Unit.Point).Table(TablaProductos =>
            {
                TablaProductos.ColumnsDefinition(Columnas =>
                {
                    Columnas.RelativeColumn();
                    Columnas.RelativeColumn(Convert.ToSingle(1.5));
                    Columnas.RelativeColumn();
                    Columnas.RelativeColumn();
                });

                TablaProductos.Header(_header =>
                {
                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Cantidad").Black();
                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Producto").Black();
                    _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Precio Unitario").Black();
                    _header.Cell().Padding(4, Unit.Point).AlignCenter().Text("Precio Total").Black();
                });

                foreach (DataGridViewRow Fila in dgvProductos.Rows)
                {
                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(Fila.Cells["Cantidad"].Value.ToString());
                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(Fila.Cells["Producto"].Value.ToString());
                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(Fila.Cells["PrecioUnitario"].Value.ToString());
                    TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(Fila.Cells["PrecioTotal"].Value.ToString());
                }
            });
        });
        page.Content().Element(ContainerTablaTotal =>
        {
            ContainerTablaTotal.BorderLeft(1, Unit.Point).BorderRight(1, Unit.Point).BorderBottom(1, Unit.Point).Table(TablaTotal =>
            {
                TablaTotal.ColumnsDefinition(Columnas =>
                {
                    Columnas.RelativeColumn();
                    Columnas.RelativeColumn();
                });

                for (int i = 0; i < dgvImpuestos.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvImpuestos.Columns.Count; j++)
                    {
                        TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(dgvImpuestos[j, i].Value.ToString());
                    }
                }
            });
        });*/
        /*page.Content().PaddingTop(10).Container(Contenido =>
        {
            Contenido.RelativeItem().Border(1, Unit.Point).Row(FilaTablaproductos =>
            {
                FilaTablaproductos.RelativeItem().Table(TablaProductos =>
                {
                    TablaProductos.ColumnsDefinition(Columnas =>
                    {
                        Columnas.RelativeColumn();
                        Columnas.RelativeColumn(Convert.ToSingle(1.5));
                        Columnas.RelativeColumn();
                        Columnas.RelativeColumn();
                    });

                    TablaProductos.Header(_header =>
                    {
                        _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Cantidad").Black();
                        _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Producto").Black();
                        _header.Cell().BorderRight(Convert.ToSingle(0.8), Unit.Point).BorderColor("DDDDDD").Padding(4, Unit.Point).AlignCenter().Text("Precio Unitario").Black();
                        _header.Cell().Padding(4, Unit.Point).AlignCenter().Text("Precio Total").Black();
                    });

                    foreach (DataGridViewRow Fila in dgvProductos.Rows)
                    {
                        TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(Fila.Cells["Cantidad"].Value.ToString());
                        TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(Fila.Cells["Producto"].Value.ToString());
                        TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(Fila.Cells["PrecioUnitario"].Value.ToString());
                        TablaProductos.Cell().Border(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(Fila.Cells["PrecioTotal"].Value.ToString());
                    }
                });
            });
            Contenido.RelativeItem().Row(FilaTablaTotal =>
            {
                FilaTablaTotal.RelativeItem().BorderLeft(1, Unit.Point).BorderRight(1, Unit.Point).BorderBottom(1, Unit.Point).Column(ColumnaTablaTotal =>
                {
                    ColumnaTablaTotal.Item().Table(TablaTotal =>
                    {
                        TablaTotal.ColumnsDefinition(Columnas =>
                        {
                            Columnas.RelativeColumn();
                            Columnas.RelativeColumn();
                        });

                        for (int i = 0; i < dgvImpuestos.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvImpuestos.Columns.Count; j++)
                            {
                                TablaTotal.Cell().BorderBottom(Convert.ToSingle(0.5), Unit.Point).PaddingLeft(10, Unit.Point).PaddingRight(10, Unit.Point).Text(dgvImpuestos[j, i].Value.ToString());
                            }
                        }
                    });
                });
            });
        });
    });
});
document.GeneratePdf(guardar.FileName);
}
}*/
        #endregion

    }
}
