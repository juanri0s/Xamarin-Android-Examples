// Xamarin Class to discover bluetooth devices
public class BluetoothDeviceReceiver : BroadcastReceiver
{
    public override void OnReceive(Context context, Intent intent)
    {
        string action = intent.Action;

        // When discovery starts
        if (BluetoothAdapter.ActionDiscoveryStarted.Equals(action))
        {
            // Show in log when discovery starts
            Log.Debug("Bluetooth Action Occured: ", action.ToString());
        }
        // When discovery finds a device
        if (BluetoothDevice.ActionFound.Equals(action))
        {
            // Show in log when a device is found
            Log.Debug("Bluetooth Action Occured: ", action.ToString());

            // Get the BluetoothDevice object from the Intent
            BluetoothDevice device = (BluetoothDevice)intent.GetParcelableExtra(BluetoothDevice.ExtraDevice);

            // What do you want to do with the device that is discovered?
            // Normally you would add it to a list

            if (device.BondState != Bond.Bonded)
            {
                // The device found is already connected, what do you want to do with it?
            }
        }
        // When discovery has finished
        if (action == BluetoothAdapter.ActionDiscoveryFinished)
        {
            // Show in log when a discovery has finished, usually a 15 second process
            Log.Debug("Bluetooth Action Occured: ", action.ToString());

            // What do you want to do when you have finished discovering?

        }
    }
}