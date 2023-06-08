using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;




namespace vegwtation
{
    public partial class Form1 : Form
    {
        private Point Mouse_Down_Location;
        private string Image_Path;
        private Rectangle Selected_Area;
        private bool Is_Selected_Area = false;


        public Form1()
        {
            InitializeComponent();
            Picture_Box_Main1.MouseDown += Picture_Box_Main1_MouseDown;
            Picture_Box_Main1.MouseMove += Picture_Box_Main1_MouseMove;
            Picture_Box_Main1.MouseUp += Picture_Box_Main1_MouseUp;
        }

        private void Start_Button(object sender, EventArgs e)
        {
            OpenFileDialog Open_File_Dialog = new OpenFileDialog();
            Open_File_Dialog.Filter = "Images (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            DialogResult result = Open_File_Dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            Image_Path = Open_File_Dialog.FileName;

            Picture_Box_Main1.Image = Image.FromFile(Image_Path);
        }

        private void All_Calculation(string Image_Path)
        {
            double Total_Ndvi_Val = 0, NDVI = 0, count = 0;
            double Wheat_Rating_St = 0.8, Corn_Rating_St = 0.6, Soybeans_Rating_St = 0.9;
            double Oats_Rating_St = 0.7;
            double Millet_Rating_St = 0.5;
            double Sunflower_Rating_St = 0.8;
            double Rice_Rating_St = 0.6;
            var Original_Image = new Bitmap(Image_Path);

            if (Original_Image.PixelFormat != PixelFormat.Format24bppRgb)
            {
                Console.WriteLine("The image isn't in RGB format.\n");
                Console.WriteLine("Converting the image to RGB format");

                Bitmap New_Image = new Bitmap(Original_Image.Width, Original_Image.Height, PixelFormat.Format24bppRgb);
                using (Graphics g = Graphics.FromImage(New_Image))
                {
                    g.DrawImage(Original_Image, 0, 0, Original_Image.Width, Original_Image.Height);
                }

                Original_Image = New_Image;
            }

          
            bool Is_Wheat_Selected = Wheat.Checked;
            bool Is_Corn_Selected = Corn.Checked;
            bool Is_checkBox_SOYA_Selected = checkBoxSOYA.Checked;
            bool Is_Oat_Selected = Oat.Checked;
            bool Is_Millet_Selected = Millet.Checked;
            bool Is_Sunflower_Selected = Sunflower.Checked;
            bool Is_Rice_Selected = Rice.Checked;

            if (!Selected_Area.IsEmpty)
            {
                for (int i = Selected_Area.Left; i < Selected_Area.Right; i++)
                {
                    for (int j = Selected_Area.Top; j < Selected_Area.Bottom; j++)
                    {
                        Color pixel = Original_Image.GetPixel(i, j);
                        double red = (double)pixel.R / 255;
                        double nir = (double)pixel.G / 255;

                        NDVI = (double)(nir - red) / (nir + red);
                        Total_Ndvi_Val += NDVI;
                        count++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Original_Image.Width; i++)
                {
                    for (int j = 0; j < Original_Image.Height; j++)
                    {
                        Color pixel = Original_Image.GetPixel(i, j);
                        double red = (double)pixel.R / 255;
                        double nir = (double)pixel.G / 255;

                        NDVI = (double)(nir - red) / (nir + red);
                        Total_Ndvi_Val += NDVI;
                        count++;
                    }
                }
            }

            double Avg_NDVI = Total_Ndvi_Val / count;
            AVG_INDEX_TX_BOX.Text = Math.Round(Avg_NDVI, 3).ToString();

            // Display crop type and rating based on average NDVI value
            if (Is_Wheat_Selected && Avg_NDVI >= Wheat_Rating_St)
            {
                Output_Label.Text = "Wheat selected.Rating of the crop type is " + Wheat_Rating_St + ".";
            }
            else if (Is_Wheat_Selected && Avg_NDVI < Wheat_Rating_St)
            {
                Output_Label.Text = "Wheat selected. Rating of the crop type is " + Wheat_Rating_St + ". The crop type has a lower rating than the top rating  " + Math.Round((Wheat_Rating_St - Avg_NDVI) * 100, 2) + "%.";
            }
            if (Is_Corn_Selected && Avg_NDVI >= Corn_Rating_St)
            {
                Output_Label.Text = "Corn selected.Rating of the crop type is " + Corn_Rating_St + ".";
            }
            else if (Is_Corn_Selected && Avg_NDVI < Corn_Rating_St)
            {
                Output_Label.Text = "Corn selected.Rating of the crop type is " + Corn_Rating_St + ". The crop type has a lower rating than the top rating " + Math.Round((Corn_Rating_St - Avg_NDVI) * 100, 2) + "%.";
            }
            if (Is_checkBox_SOYA_Selected && Avg_NDVI >= Soybeans_Rating_St)
            {
                Output_Label.Text = "Soybeans selected.Rating of the crop type is " + Soybeans_Rating_St + ".";
            }
            else if (Is_checkBox_SOYA_Selected && Avg_NDVI < Soybeans_Rating_St)
            {
                Output_Label.Text = "Soybeans selected.Rating of the crop type is " + Soybeans_Rating_St + ". The crop type has a lower rating than the top rating  " + Math.Round((Soybeans_Rating_St - Avg_NDVI) * 100, 2) + "%.";
            }
            if (Is_Oat_Selected && Avg_NDVI >= Oats_Rating_St)
            {
                Output_Label.Text = "Oats selected.Rating of the crop type is " + Oats_Rating_St + ".";
            }
            else if (Is_Oat_Selected && Avg_NDVI < Oats_Rating_St)
            {
                Output_Label.Text = "Oats selected.Rating of the crop type is " + Oats_Rating_St + ". The crop type has a lower rating than the top rating  " + Math.Round((Oats_Rating_St - Avg_NDVI) * 100, 2) + "%.";
            }
            if (Is_Millet_Selected && Avg_NDVI >= Millet_Rating_St)
            {
                Output_Label.Text = "Millet selected. Rating of the crop type is " + Millet_Rating_St + ".";
            }
            else if (Is_Millet_Selected && Avg_NDVI < Millet_Rating_St)
            {
                Output_Label.Text = "Millet selected. Rating of the crop type is " + Millet_Rating_St + ". The crop type has a lower rating than the top rating " + Math.Round((Millet_Rating_St - Avg_NDVI) * 100, 2) + "%.";
            }
            if (Is_Sunflower_Selected && Avg_NDVI >= Sunflower_Rating_St)
            {
                Output_Label.Text = "Sunflower selected. Rating of the crop type is " + Sunflower_Rating_St + ".";
            }
            else if (Is_Sunflower_Selected && Avg_NDVI < Sunflower_Rating_St)
            {
                Output_Label.Text = "Sunflower selected. Rating of the crop type is " + Sunflower_Rating_St + ". The crop type has a lower rating than the top rating " + Math.Round((Sunflower_Rating_St - Avg_NDVI) * 100, 2) + "%.";
            }
            if (Is_Rice_Selected && Avg_NDVI >= Rice_Rating_St)
            {
                Output_Label.Text = "Rice selected. Rating of the crop type is " + Rice_Rating_St + ".";
            }
            else if (Is_Rice_Selected && Avg_NDVI < Rice_Rating_St)
            {
                Output_Label.Text = "Rice selected. Rating of the crop type is " + Rice_Rating_St + ". The crop type has a lower rating than the top rating " + Math.Round((Rice_Rating_St - Avg_NDVI) * 100, 2) + "%.";
            }
            Original_Image.Dispose();

        }

        private void Calculation_Of_INDEX(object sender, EventArgs e)
        {
            if (Picture_Box_Main1.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            All_Calculation(Image_Path);
        }

        private void Picture_Box_Main1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Picture_Box_Main1.Image == null)
            {
                return;
            }

            Mouse_Down_Location = e.Location;
            Is_Selected_Area = true;
        }

        private void Picture_Box_Main1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Is_Selected_Area || Picture_Box_Main1.Image == null)
            {
                return;
            }

            Point mouseCurrentLocation = e.Location;
            Selected_Area = new Rectangle(
                Math.Min(Mouse_Down_Location.X, mouseCurrentLocation.X),
                Math.Min(Mouse_Down_Location.Y, mouseCurrentLocation.Y),
                Math.Abs(Mouse_Down_Location.X - mouseCurrentLocation.X),
                Math.Abs(Mouse_Down_Location.Y - mouseCurrentLocation.Y)
            );

            using (Graphics g = Graphics.FromImage(Picture_Box_Main1.Image))
            {
                g.DrawRectangle(Pens.Blue, Selected_Area);
            }

            Picture_Box_Main1.Refresh();
        }
        private void Picture_Box_Main1_MouseUp(object sender, MouseEventArgs e)
        {
            Is_Selected_Area = false;
        }
        private void Calculation_Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Image_Path))
            {
                MessageBox.Show("Please select image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            All_Calculation(Image_Path);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Is_Selected_Area && Picture_Box_Main1.Image != null)
            {
                using (Pen pen = new Pen(Color.Red))
                {
                    e.Graphics.DrawRectangle(pen, Selected_Area);
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!Selected_Area.IsEmpty)
            {

                using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.White)))
                {
                    e.Graphics.FillRectangle(brush, Selected_Area);
                }
            }
        }
        private void Picture_Box_Main1_Click(object sender, EventArgs e)
        {

        }
    }
}
