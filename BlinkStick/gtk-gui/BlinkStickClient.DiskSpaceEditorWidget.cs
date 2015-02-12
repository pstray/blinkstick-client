
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class DiskSpaceEditorWidget
	{
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.ComboBox comboboxDrive;
		
		private global::Gtk.ComboBox comboboxSizeType;
		
		private global::Gtk.Label labelCheck;
		
		private global::Gtk.Label labelDrive;
		
		private global::Gtk.Label labelMinutes;
		
		private global::Gtk.Label labelWhen;
		
		private global::Gtk.SpinButton spinbuttonCheckPeriod;
		
		private global::Gtk.SpinButton spinbuttonSize;
		
		private global::Gtk.Label GtkLabel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.DiskSpaceEditorWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BlinkStickClient.DiskSpaceEditorWidget";
			// Container child BlinkStickClient.DiskSpaceEditorWidget.Gtk.Container+ContainerChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(12));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxDrive = global::Gtk.ComboBox.NewText ();
			this.comboboxDrive.Name = "comboboxDrive";
			this.table1.Add (this.comboboxDrive);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxDrive]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxSizeType = global::Gtk.ComboBox.NewText ();
			this.comboboxSizeType.AppendText (global::Mono.Unix.Catalog.GetString ("MB"));
			this.comboboxSizeType.AppendText (global::Mono.Unix.Catalog.GetString ("GB"));
			this.comboboxSizeType.Name = "comboboxSizeType";
			this.table1.Add (this.comboboxSizeType);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxSizeType]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCheck = new global::Gtk.Label ();
			this.labelCheck.Name = "labelCheck";
			this.labelCheck.Xalign = 1F;
			this.labelCheck.LabelProp = global::Mono.Unix.Catalog.GetString ("Check every");
			this.table1.Add (this.labelCheck);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelCheck]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelDrive = new global::Gtk.Label ();
			this.labelDrive.Name = "labelDrive";
			this.labelDrive.Xalign = 1F;
			this.labelDrive.LabelProp = global::Mono.Unix.Catalog.GetString ("Monitor drive:");
			this.table1.Add (this.labelDrive);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelDrive]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelMinutes = new global::Gtk.Label ();
			this.labelMinutes.Name = "labelMinutes";
			this.labelMinutes.Xalign = 0F;
			this.labelMinutes.LabelProp = global::Mono.Unix.Catalog.GetString ("min");
			this.table1.Add (this.labelMinutes);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelMinutes]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelWhen = new global::Gtk.Label ();
			this.labelWhen.Name = "labelWhen";
			this.labelWhen.Xalign = 1F;
			this.labelWhen.LabelProp = global::Mono.Unix.Catalog.GetString ("Free disk space is less than");
			this.table1.Add (this.labelWhen);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelWhen]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinbuttonCheckPeriod = new global::Gtk.SpinButton (1D, 120D, 1D);
			this.spinbuttonCheckPeriod.CanFocus = true;
			this.spinbuttonCheckPeriod.Name = "spinbuttonCheckPeriod";
			this.spinbuttonCheckPeriod.Adjustment.PageIncrement = 10D;
			this.spinbuttonCheckPeriod.ClimbRate = 1D;
			this.spinbuttonCheckPeriod.Numeric = true;
			this.spinbuttonCheckPeriod.Value = 1D;
			this.table1.Add (this.spinbuttonCheckPeriod);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinbuttonCheckPeriod]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinbuttonSize = new global::Gtk.SpinButton (1D, 1000D, 1D);
			this.spinbuttonSize.CanFocus = true;
			this.spinbuttonSize.Name = "spinbuttonSize";
			this.spinbuttonSize.Adjustment.PageIncrement = 10D;
			this.spinbuttonSize.ClimbRate = 1D;
			this.spinbuttonSize.Numeric = true;
			this.spinbuttonSize.Value = 1D;
			this.table1.Add (this.spinbuttonSize);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinbuttonSize]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.table1);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel = new global::Gtk.Label ();
			this.GtkLabel.Name = "GtkLabel";
			this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Configure Disk Space Notification</b>");
			this.GtkLabel.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel;
			this.Add (this.frame1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}