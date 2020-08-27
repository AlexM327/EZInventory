﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EZInventory.InfoClasses;

namespace EZInventory.UserControls {
	/// <summary>
	/// Interaction logic for UserControl1.xaml
	/// </summary>
	public partial class DeviceInfoUserControl : UserControl {
		public DeviceInfoUserControl() {

			InitializeComponent();
			this.DataContext = this;
		}

		public DeviceInfoUserControl(DeviceInfo info) {
			Manufacturer = info.Manufacturer;
			Model = info.Model;
			SerialNumber = info.SerialNumber;
			DriverName = info.DriverName;

			InitializeComponent();
			this.DataContext = this;
		}

		public string Manufacturer { get; set; }

		public string Model { get; set; }

		public string SerialNumber { get; set; }

		public string DriverName { get; set; }

		public string Title { get; set; }


	}
}
