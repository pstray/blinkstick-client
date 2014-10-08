
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class PatternDialog
	{
		private global::Gtk.HBox hboxHorizontalSplit;
		
		private global::Gtk.VBox vboxLeft;
		
		private global::BlinkStickClient.BlinkStickEmulatorWidget blinkstickemulatorwidget;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeviewPatterns;
		
		private global::Gtk.HBox hboxNewPatternButtons;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Button buttonAddPattern;
		
		private global::Gtk.Alignment alignment2;
		
		private global::Gtk.VBox vboxRight;
		
		private global::Gtk.HBox hboxAnimationsTitle;
		
		private global::Gtk.Label labelPattern;
		
		private global::Gtk.Button buttonProperties;
		
		private global::Gtk.ScrolledWindow scrolledwindowAnimations;
		
		private global::Gtk.VBox vboxAnimations;
		
		private global::Gtk.HBox hboxNewAnimationButtons;
		
		private global::Gtk.Alignment alignment3;
		
		private global::Gtk.Button buttonAddAnimation;
		
		private global::Gtk.Alignment alignment4;
		
		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.PatternDialog
			this.Name = "BlinkStickClient.PatternDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child BlinkStickClient.PatternDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog_content";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog_content.Gtk.Box+BoxChild
			this.hboxHorizontalSplit = new global::Gtk.HBox ();
			this.hboxHorizontalSplit.Name = "hboxHorizontalSplit";
			this.hboxHorizontalSplit.Spacing = 6;
			// Container child hboxHorizontalSplit.Gtk.Box+BoxChild
			this.vboxLeft = new global::Gtk.VBox ();
			this.vboxLeft.Name = "vboxLeft";
			this.vboxLeft.Spacing = 6;
			this.vboxLeft.BorderWidth = ((uint)(6));
			// Container child vboxLeft.Gtk.Box+BoxChild
			this.blinkstickemulatorwidget = new global::BlinkStickClient.BlinkStickEmulatorWidget ();
			this.blinkstickemulatorwidget.Events = ((global::Gdk.EventMask)(256));
			this.blinkstickemulatorwidget.Name = "blinkstickemulatorwidget";
			this.vboxLeft.Add (this.blinkstickemulatorwidget);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxLeft [this.blinkstickemulatorwidget]));
			w2.Position = 0;
			// Container child vboxLeft.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewPatterns = new global::Gtk.TreeView ();
			this.treeviewPatterns.CanFocus = true;
			this.treeviewPatterns.Name = "treeviewPatterns";
			this.treeviewPatterns.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.treeviewPatterns);
			this.vboxLeft.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vboxLeft [this.GtkScrolledWindow]));
			w4.Position = 1;
			// Container child vboxLeft.Gtk.Box+BoxChild
			this.hboxNewPatternButtons = new global::Gtk.HBox ();
			this.hboxNewPatternButtons.Name = "hboxNewPatternButtons";
			this.hboxNewPatternButtons.Spacing = 6;
			// Container child hboxNewPatternButtons.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.hboxNewPatternButtons.Add (this.alignment1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxNewPatternButtons [this.alignment1]));
			w5.Position = 0;
			// Container child hboxNewPatternButtons.Gtk.Box+BoxChild
			this.buttonAddPattern = new global::Gtk.Button ();
			this.buttonAddPattern.WidthRequest = 200;
			this.buttonAddPattern.CanFocus = true;
			this.buttonAddPattern.Name = "buttonAddPattern";
			this.buttonAddPattern.UseUnderline = true;
			this.buttonAddPattern.Label = global::Mono.Unix.Catalog.GetString ("Add New Pattern");
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddPattern.Image = w6;
			this.hboxNewPatternButtons.Add (this.buttonAddPattern);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxNewPatternButtons [this.buttonAddPattern]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hboxNewPatternButtons.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.hboxNewPatternButtons.Add (this.alignment2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxNewPatternButtons [this.alignment2]));
			w8.Position = 2;
			this.vboxLeft.Add (this.hboxNewPatternButtons);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vboxLeft [this.hboxNewPatternButtons]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.hboxHorizontalSplit.Add (this.vboxLeft);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxHorizontalSplit [this.vboxLeft]));
			w10.Position = 0;
			// Container child hboxHorizontalSplit.Gtk.Box+BoxChild
			this.vboxRight = new global::Gtk.VBox ();
			this.vboxRight.Name = "vboxRight";
			this.vboxRight.Spacing = 6;
			this.vboxRight.BorderWidth = ((uint)(6));
			// Container child vboxRight.Gtk.Box+BoxChild
			this.hboxAnimationsTitle = new global::Gtk.HBox ();
			this.hboxAnimationsTitle.Name = "hboxAnimationsTitle";
			this.hboxAnimationsTitle.Spacing = 6;
			// Container child hboxAnimationsTitle.Gtk.Box+BoxChild
			this.labelPattern = new global::Gtk.Label ();
			this.labelPattern.Name = "labelPattern";
			this.labelPattern.LabelProp = global::Mono.Unix.Catalog.GetString ("Pattern Animations");
			this.hboxAnimationsTitle.Add (this.labelPattern);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hboxAnimationsTitle [this.labelPattern]));
			w11.Position = 0;
			w11.Fill = false;
			// Container child hboxAnimationsTitle.Gtk.Box+BoxChild
			this.buttonProperties = new global::Gtk.Button ();
			this.buttonProperties.CanFocus = true;
			this.buttonProperties.Name = "buttonProperties";
			this.buttonProperties.UseUnderline = true;
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-properties", global::Gtk.IconSize.Menu);
			this.buttonProperties.Image = w12;
			this.hboxAnimationsTitle.Add (this.buttonProperties);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hboxAnimationsTitle [this.buttonProperties]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vboxRight.Add (this.hboxAnimationsTitle);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxRight [this.hboxAnimationsTitle]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vboxRight.Gtk.Box+BoxChild
			this.scrolledwindowAnimations = new global::Gtk.ScrolledWindow ();
			this.scrolledwindowAnimations.WidthRequest = 300;
			this.scrolledwindowAnimations.CanFocus = true;
			this.scrolledwindowAnimations.Name = "scrolledwindowAnimations";
			this.scrolledwindowAnimations.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.scrolledwindowAnimations.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindowAnimations.Gtk.Container+ContainerChild
			global::Gtk.Viewport w15 = new global::Gtk.Viewport ();
			w15.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vboxAnimations = new global::Gtk.VBox ();
			this.vboxAnimations.Name = "vboxAnimations";
			this.vboxAnimations.BorderWidth = ((uint)(6));
			w15.Add (this.vboxAnimations);
			this.scrolledwindowAnimations.Add (w15);
			this.vboxRight.Add (this.scrolledwindowAnimations);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vboxRight [this.scrolledwindowAnimations]));
			w18.Position = 1;
			// Container child vboxRight.Gtk.Box+BoxChild
			this.hboxNewAnimationButtons = new global::Gtk.HBox ();
			this.hboxNewAnimationButtons.Name = "hboxNewAnimationButtons";
			this.hboxNewAnimationButtons.Spacing = 6;
			// Container child hboxNewAnimationButtons.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.hboxNewAnimationButtons.Add (this.alignment3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hboxNewAnimationButtons [this.alignment3]));
			w19.Position = 0;
			// Container child hboxNewAnimationButtons.Gtk.Box+BoxChild
			this.buttonAddAnimation = new global::Gtk.Button ();
			this.buttonAddAnimation.WidthRequest = 200;
			this.buttonAddAnimation.CanFocus = true;
			this.buttonAddAnimation.Name = "buttonAddAnimation";
			this.buttonAddAnimation.UseUnderline = true;
			this.buttonAddAnimation.Label = global::Mono.Unix.Catalog.GetString ("Add New Animation");
			global::Gtk.Image w20 = new global::Gtk.Image ();
			w20.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddAnimation.Image = w20;
			this.hboxNewAnimationButtons.Add (this.buttonAddAnimation);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hboxNewAnimationButtons [this.buttonAddAnimation]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hboxNewAnimationButtons.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hboxNewAnimationButtons.Add (this.alignment4);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hboxNewAnimationButtons [this.alignment4]));
			w22.Position = 2;
			this.vboxRight.Add (this.hboxNewAnimationButtons);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vboxRight [this.hboxNewAnimationButtons]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			this.hboxHorizontalSplit.Add (this.vboxRight);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hboxHorizontalSplit [this.vboxRight]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			w1.Add (this.hboxHorizontalSplit);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(w1 [this.hboxHorizontalSplit]));
			w25.Position = 0;
			// Internal child BlinkStickClient.PatternDialog.ActionArea
			global::Gtk.HButtonBox w26 = this.ActionArea;
			w26.Name = "dialog_actions";
			w26.Spacing = 10;
			w26.BorderWidth = ((uint)(5));
			w26.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog_actions.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-close";
			this.AddActionWidget (this.buttonCancel, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26 [this.buttonCancel]));
			w27.Expand = false;
			w27.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 673;
			this.DefaultHeight = 514;
			this.Show ();
			this.buttonAddPattern.Clicked += new global::System.EventHandler (this.OnButtonAddPatternClicked);
			this.buttonProperties.Clicked += new global::System.EventHandler (this.OnButtonPropertiesClicked);
			this.buttonAddAnimation.Clicked += new global::System.EventHandler (this.OnButtonAddAnimationClicked);
		}
	}
}
