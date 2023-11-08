/* Generated by MyraPad at 11/8/2023 1:41:26 PM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;
using FontStashSharp.RichText;
using AssetManagementBase;

#if STRIDE
using Stride.Core.Mathematics;
#elif PLATFORM_AGNOSTIC
using System.Drawing;
using System.Numerics;
using Color = FontStashSharp.FSColor;
#else
// MonoGame/FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endif

namespace Myra.Samples.AllWidgets
{
	partial class AllWidgets: Panel
	{
		private void BuildUI()
		{
			_menuItemOpenFile = new MenuItem();
			_menuItemOpenFile.Text = "&Open";
			_menuItemOpenFile.ShortcutText = "Ctrl+O";
			_menuItemOpenFile.Id = "_menuItemOpenFile";

			_menuItemSaveFile = new MenuItem();
			_menuItemSaveFile.Text = "&Save";
			_menuItemSaveFile.ShortcutText = "Ctrl+S";
			_menuItemSaveFile.Id = "_menuItemSaveFile";

			_menuItemChooseFolder = new MenuItem();
			_menuItemChooseFolder.Text = "Choose Fol&der";
			_menuItemChooseFolder.ShortcutText = "Ctrl+D";
			_menuItemChooseFolder.Id = "_menuItemChooseFolder";

			_menuItemChooseColor = new MenuItem();
			_menuItemChooseColor.Text = "Choose Co&lor";
			_menuItemChooseColor.ShortcutText = "Ctrl+L";
			_menuItemChooseColor.Id = "_menuItemChooseColor";

			var menuSeparator1 = new MenuSeparator();

			_menuItemQuit = new MenuItem();
			_menuItemQuit.Text = "&Quit";
			_menuItemQuit.ShortcutText = "Ctrl+Q";
			_menuItemQuit.Id = "_menuItemQuit";

			_menuFile = new MenuItem();
			_menuFile.Text = "&File";
			_menuFile.Id = "_menuFile";
			_menuFile.Items.Add(_menuItemOpenFile);
			_menuFile.Items.Add(_menuItemSaveFile);
			_menuFile.Items.Add(_menuItemChooseFolder);
			_menuFile.Items.Add(_menuItemChooseColor);
			_menuFile.Items.Add(menuSeparator1);
			_menuFile.Items.Add(_menuItemQuit);

			_menuItemCopy = new MenuItem();
			_menuItemCopy.Text = "&Copy";
			_menuItemCopy.ShortcutText = "Ctrl+Insert, Ctrl+C";
			_menuItemCopy.Id = "_menuItemCopy";

			_menuItemPaste = new MenuItem();
			_menuItemPaste.Text = "&Paste";
			_menuItemPaste.ShortcutText = "Shift+Insert, Ctrl+V";
			_menuItemPaste.Id = "_menuItemPaste";

			var menuSeparator2 = new MenuSeparator();

			_menuItemUndo = new MenuItem();
			_menuItemUndo.Text = "&Undo";
			_menuItemUndo.ShortcutText = "Ctrl+Z";
			_menuItemUndo.Id = "_menuItemUndo";

			_menuItemRedo = new MenuItem();
			_menuItemRedo.Text = "&Redo";
			_menuItemRedo.ShortcutText = "Ctrl+Y";
			_menuItemRedo.Id = "_menuItemRedo";

			_menuEdit = new MenuItem();
			_menuEdit.Text = "&Edit";
			_menuEdit.Id = "_menuEdit";
			_menuEdit.Items.Add(_menuItemCopy);
			_menuEdit.Items.Add(_menuItemPaste);
			_menuEdit.Items.Add(menuSeparator2);
			_menuEdit.Items.Add(_menuItemUndo);
			_menuEdit.Items.Add(_menuItemRedo);

			_menuItemAbout = new MenuItem();
			_menuItemAbout.Text = "&About";
			_menuItemAbout.Id = "_menuItemAbout";

			_menuHelp = new MenuItem();
			_menuHelp.Text = "&Help";
			_menuHelp.Id = "_menuHelp";
			_menuHelp.Items.Add(_menuItemAbout);

			_mainMenu = new HorizontalMenu();
			_mainMenu.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_mainMenu.Id = "_mainMenu";
			_mainMenu.Items.Add(_menuFile);
			_mainMenu.Items.Add(_menuEdit);
			_mainMenu.Items.Add(_menuHelp);

			var label1 = new Label();
			label1.Text = "Button:";

			_buttonSaveFile = new ImageTextButton();
			_buttonSaveFile.Text = "Save File";
			_buttonSaveFile.Padding = new Thickness(8, 0);
			_buttonSaveFile.Tooltip = "Tooltip 1";
			_buttonSaveFile.Id = "_buttonSaveFile";
			Grid.SetColumn(_buttonSaveFile, 1);

			_textSaveFile = new TextBox();
			_textSaveFile.Id = "_textSaveFile";
			Grid.SetColumn(_textSaveFile, 2);

			var label2 = new Label();
			label2.Text = "Another Button:";
			Grid.SetRow(label2, 1);

			_buttonOpenFile = new ImageTextButton();
			_buttonOpenFile.Text = "Open File";
			_buttonOpenFile.Padding = new Thickness(8, 0);
			_buttonOpenFile.Tooltip = "Tooltip 2";
			_buttonOpenFile.Id = "_buttonOpenFile";
			Grid.SetColumn(_buttonOpenFile, 1);
			Grid.SetRow(_buttonOpenFile, 1);

			_textOpenFile = new TextBox();
			_textOpenFile.Id = "_textOpenFile";
			Grid.SetColumn(_textOpenFile, 2);
			Grid.SetRow(_textOpenFile, 1);

			var label3 = new Label();
			label3.Text = "Blue Button:";
			Grid.SetRow(label3, 2);

			_buttonChooseFolder = new ImageTextButton("blue");
			_buttonChooseFolder.Text = "Choose Folder";
			_buttonChooseFolder.Padding = new Thickness(8, 0);
			_buttonChooseFolder.Id = "_buttonChooseFolder";
			Grid.SetColumn(_buttonChooseFolder, 1);
			Grid.SetRow(_buttonChooseFolder, 2);

			_textChooseFolder = new TextBox();
			_textChooseFolder.Id = "_textChooseFolder";
			Grid.SetColumn(_textChooseFolder, 2);
			Grid.SetRow(_textChooseFolder, 2);

			_textButtonLabel = new Label();
			_textButtonLabel.Text = "Text Button:";
			_textButtonLabel.Id = "_textButtonLabel";
			Grid.SetRow(_textButtonLabel, 3);

			var label4 = new Label();
			label4.Text = "Choose Color";

			_buttonChooseColor = new Button();
			_buttonChooseColor.Padding = new Thickness(8, 0);
			_buttonChooseColor.Id = "_buttonChooseColor";
			Grid.SetColumn(_buttonChooseColor, 1);
			Grid.SetRow(_buttonChooseColor, 3);
			_buttonChooseColor.Content = label4;

			var label5 = new Label();
			label5.Text = "Image Button:";
			Grid.SetRow(label5, 4);

			var image1 = new Image();

			_imageButton = new Button();
			_imageButton.Padding = new Thickness(8, 0);
			_imageButton.Id = "_imageButton";
			Grid.SetColumn(_imageButton, 1);
			Grid.SetRow(_imageButton, 4);
			_imageButton.Content = image1;

			var label6 = new Label();
			label6.Text = "This is checkbox";

			var checkButton1 = new CheckButton();
			checkButton1.CheckContentSpacing = 4;
			Grid.SetRow(checkButton1, 5);
			Grid.SetColumnSpan(checkButton1, 2);
			checkButton1.Content = label6;

			var label7 = new Label();
			label7.Text = "Horizontal Slider:";
			Grid.SetRow(label7, 6);

			var horizontalSlider1 = new HorizontalSlider();
			Grid.SetColumn(horizontalSlider1, 1);
			Grid.SetRow(horizontalSlider1, 6);
			Grid.SetColumnSpan(horizontalSlider1, 2);

			var label8 = new Label();
			label8.Text = "Combo Box:";
			Grid.SetRow(label8, 7);

			var listItem1 = new ListItem();
			listItem1.Text = "Red";
			listItem1.Color = Color.Red;

			var listItem2 = new ListItem();
			listItem2.Text = "Green";
			listItem2.Color = Color.Lime;

			var listItem3 = new ListItem();
			listItem3.Text = "Blue";
			listItem3.Color = ColorStorage.CreateColor(0, 128, 255, 255);

			var comboBox1 = new ComboBox();
			comboBox1.Width = 200;
			Grid.SetColumn(comboBox1, 1);
			Grid.SetRow(comboBox1, 7);
			Grid.SetColumnSpan(comboBox1, 2);
			comboBox1.Items.Add(listItem1);
			comboBox1.Items.Add(listItem2);
			comboBox1.Items.Add(listItem3);

			var label9 = new Label();
			label9.Text = "Text Field:";
			Grid.SetRow(label9, 8);

			var textBox1 = new TextBox();
			Grid.SetColumn(textBox1, 1);
			Grid.SetRow(textBox1, 8);
			Grid.SetColumnSpan(textBox1, 2);

			var label10 = new Label();
			label10.Text = "Spin Button:";
			Grid.SetRow(label10, 9);

			var spinButton1 = new SpinButton();
			spinButton1.Value = 1;
			spinButton1.Width = 100;
			Grid.SetColumn(spinButton1, 1);
			Grid.SetRow(spinButton1, 9);

			var label11 = new Label();
			label11.Text = "List Box:";
			Grid.SetRow(label11, 10);

			var listItem4 = new ListItem();
			listItem4.Text = "Red";
			listItem4.Color = Color.Red;

			var listItem5 = new ListItem();
			listItem5.Text = "Green";
			listItem5.Color = Color.Lime;

			var listItem6 = new ListItem();
			listItem6.Text = "Blue";
			listItem6.Color = Color.Blue;

			var listBox1 = new ListBox();
			listBox1.Width = 200;
			Grid.SetColumn(listBox1, 1);
			Grid.SetRow(listBox1, 10);
			Grid.SetColumnSpan(listBox1, 2);
			listBox1.Items.Add(listItem4);
			listBox1.Items.Add(listItem5);
			listBox1.Items.Add(listItem6);

			var label12 = new Label();
			label12.Text = "Vertical Menu:";
			Grid.SetRow(label12, 11);

			var menuItem1 = new MenuItem();
			menuItem1.Text = "Start New Game";

			var menuItem2 = new MenuItem();
			menuItem2.Text = "Options";

			var menuItem3 = new MenuItem();
			menuItem3.Text = "Quit";

			var verticalMenu1 = new VerticalMenu();
			Grid.SetColumn(verticalMenu1, 1);
			Grid.SetRow(verticalMenu1, 11);
			verticalMenu1.Items.Add(menuItem1);
			verticalMenu1.Items.Add(menuItem2);
			verticalMenu1.Items.Add(menuItem3);

			var label13 = new Label();
			label13.Text = "Tree";
			Grid.SetRow(label13, 12);

			_gridRight = new Grid();
			_gridRight.ColumnSpacing = 8;
			_gridRight.RowSpacing = 8;
			_gridRight.DefaultRowProportion = new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			};
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			_gridRight.Id = "_gridRight";
			_gridRight.Widgets.Add(label1);
			_gridRight.Widgets.Add(_buttonSaveFile);
			_gridRight.Widgets.Add(_textSaveFile);
			_gridRight.Widgets.Add(label2);
			_gridRight.Widgets.Add(_buttonOpenFile);
			_gridRight.Widgets.Add(_textOpenFile);
			_gridRight.Widgets.Add(label3);
			_gridRight.Widgets.Add(_buttonChooseFolder);
			_gridRight.Widgets.Add(_textChooseFolder);
			_gridRight.Widgets.Add(_textButtonLabel);
			_gridRight.Widgets.Add(_buttonChooseColor);
			_gridRight.Widgets.Add(label5);
			_gridRight.Widgets.Add(_imageButton);
			_gridRight.Widgets.Add(checkButton1);
			_gridRight.Widgets.Add(label7);
			_gridRight.Widgets.Add(horizontalSlider1);
			_gridRight.Widgets.Add(label8);
			_gridRight.Widgets.Add(comboBox1);
			_gridRight.Widgets.Add(label9);
			_gridRight.Widgets.Add(textBox1);
			_gridRight.Widgets.Add(label10);
			_gridRight.Widgets.Add(spinButton1);
			_gridRight.Widgets.Add(label11);
			_gridRight.Widgets.Add(listBox1);
			_gridRight.Widgets.Add(label12);
			_gridRight.Widgets.Add(verticalMenu1);
			_gridRight.Widgets.Add(label13);

			var scrollViewer1 = new ScrollViewer();
			scrollViewer1.ShowHorizontalScrollBar = false;
			scrollViewer1.Content = _gridRight;

			var label14 = new Label();
			label14.Text = "Vertical Slider:";

			var verticalSlider1 = new VerticalSlider();
			verticalSlider1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			Grid.SetRow(verticalSlider1, 1);

			var grid1 = new Grid();
			grid1.RowSpacing = 8;
			grid1.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.Widgets.Add(label14);
			grid1.Widgets.Add(verticalSlider1);

			var label15 = new Label();
			label15.Text = "Progress Bars:";

			_horizontalProgressBar = new HorizontalProgressBar();
			_horizontalProgressBar.Id = "_horizontalProgressBar";
			Grid.SetRow(_horizontalProgressBar, 1);

			_verticalProgressBar = new VerticalProgressBar();
			_verticalProgressBar.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_verticalProgressBar.Id = "_verticalProgressBar";
			Grid.SetRow(_verticalProgressBar, 2);

			var grid2 = new Grid();
			grid2.RowSpacing = 8;
			grid2.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid2.Widgets.Add(label15);
			grid2.Widgets.Add(_horizontalProgressBar);
			grid2.Widgets.Add(_verticalProgressBar);

			var verticalSplitPane1 = new VerticalSplitPane();
			verticalSplitPane1.Widgets.Add(grid1);
			verticalSplitPane1.Widgets.Add(grid2);

			var horizontalSplitPane1 = new HorizontalSplitPane();
			StackPanel.SetProportionType(horizontalSplitPane1, Myra.Graphics2D.UI.ProportionType.Fill);
			horizontalSplitPane1.Widgets.Add(scrollViewer1);
			horizontalSplitPane1.Widgets.Add(verticalSplitPane1);

			var verticalStackPanel1 = new VerticalStackPanel();
			verticalStackPanel1.Spacing = 8;
			verticalStackPanel1.Widgets.Add(_mainMenu);
			verticalStackPanel1.Widgets.Add(horizontalSplitPane1);

			_labelOverGui = new Label();
			_labelOverGui.Text = "Is mouse over GUI: true";
			_labelOverGui.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Bottom;
			_labelOverGui.Id = "_labelOverGui";

			
			Widgets.Add(verticalStackPanel1);
			Widgets.Add(_labelOverGui);
		}

		
		public MenuItem _menuItemOpenFile;
		public MenuItem _menuItemSaveFile;
		public MenuItem _menuItemChooseFolder;
		public MenuItem _menuItemChooseColor;
		public MenuItem _menuItemQuit;
		public MenuItem _menuFile;
		public MenuItem _menuItemCopy;
		public MenuItem _menuItemPaste;
		public MenuItem _menuItemUndo;
		public MenuItem _menuItemRedo;
		public MenuItem _menuEdit;
		public MenuItem _menuItemAbout;
		public MenuItem _menuHelp;
		public HorizontalMenu _mainMenu;
		public ImageTextButton _buttonSaveFile;
		public TextBox _textSaveFile;
		public ImageTextButton _buttonOpenFile;
		public TextBox _textOpenFile;
		public ImageTextButton _buttonChooseFolder;
		public TextBox _textChooseFolder;
		public Label _textButtonLabel;
		public Button _buttonChooseColor;
		public Button _imageButton;
		public Grid _gridRight;
		public HorizontalProgressBar _horizontalProgressBar;
		public VerticalProgressBar _verticalProgressBar;
		public Label _labelOverGui;
	}
}
