using Memento.Memento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        static CareTaker caretaker = new CareTaker();
        Document doc = new Document() { name = "Informe.docx", content = "0-Datos sobre el informe..." };
        int count = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            MessageBox.Show(doc.content);

            caretaker.Add(doc.SaveMemento());

            doc.content = "1-Cambiando el contenido...";
            caretaker.Add(doc.SaveMemento());
            MessageBox.Show(doc.content);

            doc.content = "2-Cambiando el contenido... de nuevo...";
            caretaker.Add(doc.SaveMemento());
            MessageBox.Show(doc.content);

            doc.content = "3-Una vez más...";
            caretaker.Add(doc.SaveMemento());
            MessageBox.Show(doc.content);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= 0)
            {  
                Memento.Memento m = caretaker.GetMemento(count);
                count--;

                doc.restoreMemento(m);

                MessageBox.Show(doc.content);
            }
            else
            {
                MessageBox.Show("No hay elementos para recuperar.");
            }
        }
    }
}
