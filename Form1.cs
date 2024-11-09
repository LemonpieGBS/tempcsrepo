using WFATest.Models;

namespace WFATest;

public partial class Form1 : Form
{
    private readonly List<Producto> _productos = [];
    private Producto? _productoSeleccionado = null;
    public Form1()
    {
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        InitializeComponent();
    }

    private void ActualizarGridView()
    {
        dgvProductos.DataSource = null;
        dgvProductos.DataSource = _productos;
    }

    private void btnCrear_Click(object sender, EventArgs e)
    {
        if (txtId.Text == string.Empty || txtNombre.Text == string.Empty || txtPrecio.Text == string.Empty)
        {
            MessageBox.Show(@"Uno o más campos estan vacíos", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            try
            {
                int nuevoId = int.Parse(txtId.Text);

                foreach (Producto producto in _productos)
                {
                    if (producto.Id == nuevoId)
                    {
                        MessageBox.Show(@"El id del producto ya existe", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string nuevoNombre = txtNombre.Text;
                decimal nuevoPrecio = decimal.Parse(txtPrecio.Text);

                Producto nuevoProducto = new(
                    argId: nuevoId,
                    argNombre: nuevoNombre,
                    argPrecio: nuevoPrecio );
                
                _productos.Add(nuevoProducto);

                (txtId.Text, txtNombre.Text, txtPrecio.Text) = ("","","");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnLeer_Click(object sender, EventArgs e)
    {
        ActualizarGridView();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        if (txtId.Text == string.Empty || txtNombre.Text == string.Empty || txtPrecio.Text == string.Empty)
        {
            MessageBox.Show(@"Uno o más campos estan vacíos", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (_productoSeleccionado == null)
        {
            MessageBox.Show(@"No hay ningun producto seleccionado!", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        } else {
            try
            {
                int nuevoId = int.Parse(txtId.Text);

                foreach (Producto producto in _productos)
                {
                    if (producto.Id != nuevoId || producto == _productoSeleccionado) continue;
                    MessageBox.Show(@"El id del producto ya existe", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string nuevoNombre = txtNombre.Text;
                decimal nuevoPrecio = decimal.Parse(txtPrecio.Text);

                _productoSeleccionado.Id = nuevoId;
                _productoSeleccionado.Nombre = nuevoNombre;
                _productoSeleccionado.Precio = nuevoPrecio;

                (txtId.Text, txtNombre.Text, txtPrecio.Text) = ("","","");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (_productoSeleccionado == null)
        {
            MessageBox.Show(@"No hay ningun producto seleccionado!", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        else
        {
            if (MessageBox.Show(@$"Está seguro de borrar '{_productoSeleccionado.Nombre}'", @"Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                
            }
        }
    }

    private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (dgvProductos.CurrentRow is not null)
            _productoSeleccionado = dgvProductos.CurrentRow.DataBoundItem as Producto;
    }

    private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (_productoSeleccionado is not null)
        {
            txtId.Text = _productoSeleccionado.Id.ToString();
            txtNombre.Text = _productoSeleccionado.Nombre;
            txtPrecio.Text = _productoSeleccionado.Precio.ToString();
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Environment.Exit(0);
    }
}