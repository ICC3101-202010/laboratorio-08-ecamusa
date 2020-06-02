using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace laboratorio_8
{
    [Serializable]
    public partial class Form1 : Form
    {
        List<string> locales = new List<string>();
        string z,name,horario,rut,particularidad;
        Local local = new Local();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Local.creararchivo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible=true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void revlocal_Click(object sender, EventArgs e)
        {
            panel3.Visible=true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void agregar_Click(object sender, EventArgs e)
        {

        }



        private void categoria_Click(object sender, EventArgs e)
        {

        }

        private void volveratrastienda_Click(object sender, EventArgs e)
        {
            paneltienda1.Visible = false;
            panel2.Visible = true;
        }

        private void buttontienda_Click(object sender, EventArgs e)
        {
            paneltienda1.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            z = "tienda";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paneltienda1.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            particularidad = textBox1.Text;
            Tienda tienda = new Tienda(name, rut, horario, particularidad);
            local.addlocaltienda(tienda);
           

        }

        private void tiendasiguiente_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            name = textBox2tienda.Text;
        }

        private void volveratrastienda2_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (z == "tienda")
            {
                panel4.Visible = true;
                panel7.Visible = false;
                panel8.Visible = false;
                horario = textBox3.Text;
                Tienda tienda = new Tienda(name,rut,horario,particularidad);
                local.addlocaltienda(tienda);
                


            }
            if (z == "restaurante")
            { 
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                horario = textBox3.Text;
                Restaurantes rest = new Restaurantes(name, rut, horario, particularidad);
                local.addlocalRest(rest);

            }
            if (z == "cine")
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = false;
                horario = textBox3.Text;
                Cine cine = new Cine(name, rut, horario, particularidad);
                local.addlocalcine(cine);
            }
            if (z == "recreacional")
            {
                paneltienda1.Visible=  false;
                panel4.Visible = false;
                panel2.Visible = false;
                horario = textBox3.Text;
                Recreacional rec = new Recreacional(name, rut, horario);
                local.addlocalre(rec);
                

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            rut = textBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void buttonrestaurante_Click(object sender, EventArgs e)
        {
            paneltienda1.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            z = "restaurante";
        }

        private void buttoncine_Click(object sender, EventArgs e)
        {
            paneltienda1.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            z = "cine";
        }

        private void buttonrecreacional_Click(object sender, EventArgs e)
        {
            paneltienda1.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            z = "recreacional";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            paneltienda1.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            particularidad = "si";
            Restaurantes rest = new Restaurantes(name, rut, horario, particularidad);
            local.addlocalRest(rest);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            panel6.Visible = false;
            paneltienda1.Visible = false;
            particularidad = textBox4.Text;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            local.readempresa();
            richTextBox1.Text = "";
            richTextBox1.Clear();
            if (z == "recreacional")
            {

            }
            else
            {
                local.total.RemoveAt(0);
            }
            foreach (var a in local.total)
            {
                
                richTextBox1.Text += a;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            paneltienda1.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            particularidad = "no";
            Restaurantes rest = new Restaurantes(name, rut, horario, particularidad);
            local.addlocalRest(rest);
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }
    }
}
