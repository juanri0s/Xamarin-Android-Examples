// Code to implement a custom alert dialog in an activity

ContextThemeWrapper contextThemeWrapper = new ContextThemeWrapper(Activity, Resource.Style.CustomDialog);

// Set up the dialog
Dialog dialog = new Dialog(contextThemeWrapper);
dialog.SetCancelable(true);
dialog.Show();

// Set the view of the dialog to be our custom dialog layout
dialog.SetContentView(Resource.Layout.custom_dialog);

// Grab the xml textviews and buttons from the layout so we can manipulate the text
TextView dialogTitle = dialog.FindViewById<TextView>(Resource.Id.dialogTitle);
TextView dialogSubtitle = dialog.FindViewById<TextView>(Resource.Id.dialogSubtitle);
Button negButton = dialog.FindViewById<Button>(Resource.Id.negButton);
Button posButton = dialog.FindViewById<Button>(Resource.Id.posButton);

dialogTitle.Text = "Title text goes here";
dialogSubtitle.Text = "Message text goes here";
posButton.Text = "Positive Button text goes here";
negButton.Text = "Negative Button text goes here";

negButton.Click += (s, p) => "when the user clicks on the negative button, place the action here";
posButton.Click += (s, p) => "when the user clicks on the positive button, place the action here";


