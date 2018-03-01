using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace Archivos_de_Texto_y_Archivos_Binarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Busca la imagen dentro del directorio con un filtro de solo imagenes bmp
        /// </summary>
        OpenFileDialog openFile = new OpenFileDialog
        {
            InitialDirectory = Directory.GetCurrentDirectory(),
            Filter = "image file (*.bmp)|*.bmp",
            RestoreDirectory = true,
        };

        /// <summary>
        /// Guarda el archivo en el directorio con un filtro de XML
        /// </summary>
        SaveFileDialog saveFile = new SaveFileDialog
        {
            InitialDirectory = Directory.GetCurrentDirectory(),
            Filter = "XML-File|*.xml"
        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream archive = new FileStream(openFile.FileName, FileMode.Open);
                byteSearch(archive);
                openImage();
                archive.Close();
            }
        }

        /// <summary>
        /// Muestra los datos del archivo seleccionado
        /// </summary>
        /// <param name="archive"></param>
        /// <returns></returns>
        int byteSearch(FileStream archive)
        {
            BinaryReader br = new BinaryReader(archive);
            archive.Seek(14, SeekOrigin.Begin);
            int header = br.ReadInt32();

            if (header == 40)
            {
                archive.Seek(0, SeekOrigin.Begin);
                string code = new string(br.ReadChars(2));
                if (code == "BM")
                {
                    archive.Seek(2, SeekOrigin.Begin);
                    int size = br.ReadInt32();

                    archive.Seek(12, SeekOrigin.Current);
                    int width = br.ReadInt32();

                    int height = br.ReadInt32();

                    archive.Seek(2, SeekOrigin.Current);
                    int bitperpixel = br.ReadInt16();

                    txtBmpdata.Text = "Real size: " + size.ToString() + "\r\n"
                        + "Width: " + width.ToString() + "\r\n"
                        + "Height: " + height.ToString() + "\r\n"
                        + "Bits per pixel: " + bitperpixel.ToString();
                }
                else
                {
                    MessageBox.Show("Not a bmp Image");
                    pictureBox1 = null;
                }
            }
            else
            {
                MessageBox.Show("Not a bmp Image");
                pictureBox1 = null;
            }
            br.Close();

            return 0;

        }

        /// <summary>
        /// Abre la imagen(archivo) seleccionada y lo muestra en el picturebox
        /// </summary>
        /// <returns></returns>
        int openImage()
        {
            try
            {
                FileStream imageArchive = new FileStream(openFile.FileName, FileMode.Open);
                pictureBox1.Image = Image.FromStream(imageArchive);
                imageArchive.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Failed loading image");
            }
            return 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            createFile();
        }

        /// <summary>
        /// Creo el archivo XML
        /// </summary>
        public void createFile()
        {
            saveFile.ShowDialog();
            FileStream fs = new FileStream(saveFile.FileName, FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);


            string chain = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"
                + "<Registration>"
                + "<data>"
                + "<name>" + txtName.Text + "</name>"
                + "<email>" + txtEmail.Text + "</email>"
                + "<age>" + txtAge.Text + "</age>"
                + "<cellphone>" + txtCellphone.Text + "</cellphone>"
                + "<address>" + txtAddress.Text + "</address>"
                + "</data>"
                + "</Registration>";

            sw.Write(chain);
            sw.Close();
            fs.Close();

        }
    }
}
