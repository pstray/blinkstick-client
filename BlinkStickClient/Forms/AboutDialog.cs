#region License
// Copyright 2013 by Agile Innovative Ltd
//
// This file is part of BlinkStick application.
//
// BlinkStick application is free software: you can redistribute 
// it and/or modify it under the terms of the GNU General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or (at your option) 
// any later version.
//		
// BlinkStick application is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
// FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with 
// BlinkStick application. If not, see http://www.gnu.org/licenses/.
#endregion

using System;

namespace BlinkStickClient
{
	public partial class AboutDialog : Gtk.Dialog
	{
		public AboutDialog ()
		{
			this.Build ();

			this.Icon = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "icon.png"));
			imageLogo.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "logo.png"));

			eventbox1.ButtonPressEvent += (object o, Gtk.ButtonPressEventArgs args) => {
				try
				{
					System.Diagnostics.Process.Start("http://www.agileinnovative.co.uk");
				}
				catch
				{
				}
			};

		}

		public static void ShowDialog(String title)
		{
			AboutDialog dialog = new AboutDialog();
			dialog.label1.LabelProp = String.Format ("<b><big>{0}</big></b>", title);
			dialog.label1.UseMarkup = true;
			dialog.Run();
			dialog.Destroy();
		}
	}
}

