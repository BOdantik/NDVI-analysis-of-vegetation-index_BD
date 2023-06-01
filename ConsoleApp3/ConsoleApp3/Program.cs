// all extention for project 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;

using System.Diagnostics;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;


// Load the image from C:\Users\marya\Videos\For3pr
string satelliteImage = @"C:\Users\marya\Videos\For3pr\image.jpg";





// Load the image into a bitmap

var bitmapImage = new Bitmap(satelliteImage);


// Convert the bitmap image to a suitable format for calculating NDVI
double[,] ndviData = new double[bitmapImage.Width, bitmapImage.Height];
for (int x = 0; x < bitmapImage.Width; x++)
{
    for (int y = 0; y < bitmapImage.Height; y++)
    {
        Color color = bitmapImage.GetPixel(x, y);
        int red = color.R;
        int green = color.G;
        if (red + green != 0)
            ndviData[x, y] = (red - green) / (double)(red + green);
        else
            ndviData[x, y] = 0;
    }
}

// Calculate the average NDVI value for the entire image
double totalNDVI = 0;
for (int x = 0; x < bitmapImage.Width; x++)
{
    for (int y = 0; y < bitmapImage.Height; y++)
    {
        totalNDVI += ndviData[x, y];
    }
}
double averageNDVI = totalNDVI / (bitmapImage.Width * bitmapImage.Height);
