AlertDialog dialogAlert;
AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
	// Allows dialog to be backed out of using back buttong or tapping off dialog
	.SetTitle("Enter the title that you want the pop up to show, usually the main action for the user");
	.SetCancelable(true);
	// The message that is displayed as the main message
	.SetMessage("Enter the message that you want to pop up");
	.SetPositiveButton("Enter the right button text here, usually the action", (s, args) =>
	{
		// Put the action that you want to happen when positive button is pressed

		// Dispose gets rid of the dialog once action happens
		alertDialog.Dispose();
	});
	.SetNegativeButton("Enter the left button text here, usually cancel", (s, args) =>
	{
		// Dispose gets rid of the dialog once action happens
		alertDialog.Dispose();
	});
	// Create and show the dialog
	dialogAlert = alertDialog.Create();
	alertDialog.Show();