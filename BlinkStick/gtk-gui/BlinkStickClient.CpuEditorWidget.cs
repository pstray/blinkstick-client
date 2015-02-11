
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class CpuEditorWidget
	{
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.RadioButton radiobuttonMonitor;
		
		private global::Gtk.Label labelMonitorHint;
		
		private global::Gtk.RadioButton radiobuttonAlert;
		
		private global::Gtk.Label labelAlertHint;
		
		private global::Gtk.Alignment alignment2;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.ComboBox comboboxTriggerType;
		
		private global::Gtk.Label labelCheck;
		
		private global::Gtk.Label labelMinutes;
		
		private global::Gtk.Label labelPercent;
		
		private global::Gtk.Label labelWhen;
		
		private global::Gtk.SpinButton spinbuttonCheckPeriod;
		
		private global::Gtk.SpinButton spinbuttonCpuPercent;
		
		private global::Gtk.Label GtkLabel2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.CpuEditorWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BlinkStickClient.CpuEditorWidget";
			// Container child BlinkStickClient.CpuEditorWidget.Gtk.Container+ContainerChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			this.GtkAlignment.TopPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radiobuttonMonitor = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Monitor"));
			this.radiobuttonMonitor.CanFocus = true;
			this.radiobuttonMonitor.Name = "radiobuttonMonitor";
			this.radiobuttonMonitor.DrawIndicator = true;
			this.radiobuttonMonitor.UseUnderline = true;
			this.radiobuttonMonitor.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.vbox2.Add (this.radiobuttonMonitor);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.radiobuttonMonitor]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelMonitorHint = new global::Gtk.Label ();
			this.labelMonitorHint.Name = "labelMonitorHint";
			this.labelMonitorHint.Xpad = 20;
			this.labelMonitorHint.Xalign = 0F;
			this.labelMonitorHint.LabelProp = global::Mono.Unix.Catalog.GetString ("<i>Uses pattern\'s first animation color to display 0% and second to transition to" +
			" 100%. Define a pattern with two Set Color animations for this to take effect</i" +
			">");
			this.labelMonitorHint.UseMarkup = true;
			this.labelMonitorHint.Wrap = true;
			this.vbox2.Add (this.labelMonitorHint);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelMonitorHint]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radiobuttonAlert = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Alert"));
			this.radiobuttonAlert.CanFocus = true;
			this.radiobuttonAlert.Name = "radiobuttonAlert";
			this.radiobuttonAlert.DrawIndicator = true;
			this.radiobuttonAlert.UseUnderline = true;
			this.radiobuttonAlert.Group = this.radiobuttonMonitor.Group;
			this.vbox2.Add (this.radiobuttonAlert);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.radiobuttonAlert]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelAlertHint = new global::Gtk.Label ();
			this.labelAlertHint.Name = "labelAlertHint";
			this.labelAlertHint.Xpad = 20;
			this.labelAlertHint.Xalign = 0F;
			this.labelAlertHint.LabelProp = global::Mono.Unix.Catalog.GetString ("<i>When event occurs triggers pattern playback</i>");
			this.labelAlertHint.UseMarkup = true;
			this.labelAlertHint.Wrap = true;
			this.vbox2.Add (this.labelAlertHint);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelAlertHint]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(40));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(5)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxTriggerType = global::Gtk.ComboBox.NewText ();
			this.comboboxTriggerType.AppendText (global::Mono.Unix.Catalog.GetString ("increases above"));
			this.comboboxTriggerType.AppendText (global::Mono.Unix.Catalog.GetString ("drops below"));
			this.comboboxTriggerType.Name = "comboboxTriggerType";
			this.table1.Add (this.comboboxTriggerType);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxTriggerType]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCheck = new global::Gtk.Label ();
			this.labelCheck.Name = "labelCheck";
			this.labelCheck.Xalign = 1F;
			this.labelCheck.LabelProp = global::Mono.Unix.Catalog.GetString ("Check every");
			this.table1.Add (this.labelCheck);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelCheck]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelMinutes = new global::Gtk.Label ();
			this.labelMinutes.Name = "labelMinutes";
			this.labelMinutes.Xalign = 0F;
			this.labelMinutes.LabelProp = global::Mono.Unix.Catalog.GetString ("min");
			this.table1.Add (this.labelMinutes);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelMinutes]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(3));
			w7.RightAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPercent = new global::Gtk.Label ();
			this.labelPercent.Name = "labelPercent";
			this.labelPercent.Xalign = 0F;
			this.labelPercent.LabelProp = global::Mono.Unix.Catalog.GetString ("%");
			this.table1.Add (this.labelPercent);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelPercent]));
			w8.LeftAttach = ((uint)(3));
			w8.RightAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelWhen = new global::Gtk.Label ();
			this.labelWhen.Name = "labelWhen";
			this.labelWhen.Xalign = 1F;
			this.labelWhen.LabelProp = global::Mono.Unix.Catalog.GetString ("When");
			this.table1.Add (this.labelWhen);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelWhen]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinbuttonCheckPeriod = new global::Gtk.SpinButton (1D, 120D, 1D);
			this.spinbuttonCheckPeriod.CanFocus = true;
			this.spinbuttonCheckPeriod.Name = "spinbuttonCheckPeriod";
			this.spinbuttonCheckPeriod.Adjustment.PageIncrement = 10D;
			this.spinbuttonCheckPeriod.ClimbRate = 1D;
			this.spinbuttonCheckPeriod.Numeric = true;
			this.spinbuttonCheckPeriod.Value = 1D;
			this.table1.Add (this.spinbuttonCheckPeriod);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinbuttonCheckPeriod]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinbuttonCpuPercent = new global::Gtk.SpinButton (0D, 100D, 1D);
			this.spinbuttonCpuPercent.CanFocus = true;
			this.spinbuttonCpuPercent.Name = "spinbuttonCpuPercent";
			this.spinbuttonCpuPercent.Adjustment.PageIncrement = 10D;
			this.spinbuttonCpuPercent.ClimbRate = 1D;
			this.spinbuttonCpuPercent.Numeric = true;
			this.table1.Add (this.spinbuttonCpuPercent);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinbuttonCpuPercent]));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			this.alignment2.Add (this.table1);
			this.vbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment2]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			this.GtkAlignment.Add (this.vbox2);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Configure CPU monitoring</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.Add (this.frame1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.radiobuttonAlert.Toggled += new global::System.EventHandler (this.OnRadiobuttonAlertToggled);
		}
	}
}