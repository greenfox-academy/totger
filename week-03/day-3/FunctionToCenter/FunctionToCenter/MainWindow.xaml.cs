﻿using System;
using System.Windows;
using GreenFox;

namespace FunctionToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            for (int i = 0; i <= 300; i += 20)
            {
                DrawLine(i, 0);
            }
            for (int i = 0; i <= 300; i += 20)
            {
                DrawLine(0, i);
            }
            for (int i = 0; i <= 300; i += 20)
            {
                DrawLine(i, 300);
            }
            for (int i = 0; i <= 300; i += 20)
            {
                DrawLine(300, i);
            }
        }
        void DrawLine(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(x, y, canvas.Width / 2, canvas.Height / 2);
        }
    }
}