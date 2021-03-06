﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class DateButton : System.Windows.Forms.Button
    {
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set 
            {
                this.Text = value.Day.ToString();
                _date = value; 
            }
        }

        public DateButton()
        {
            this.Enabled = false;
        }

        public DateButton(DateTime newDate)
        {
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            if (newDate.Date == DateTime.Now.Date)
            {
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ForeColor = Color.Green;
            }
            else
            {
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            this.Date = newDate;
        }

        public DateButton(DateTime newDate, bool bHayReserva)
        {
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            if (newDate.Date == DateTime.Now.Date)
            {
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ForeColor = Color.Green;
            }
            else
            {
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            if (bHayReserva)
            {
                this.ImageAlign = ContentAlignment.TopRight;
                this.Image = Properties.Resources.personas;
            }
            this.Date = newDate;
        }
    }
}
