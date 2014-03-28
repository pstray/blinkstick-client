using System;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using System.Runtime.InteropServices;

namespace HidSharp
{
	public class LibusbHidStream : HidStream
	{
		private HidDevice _hidDevice;
		private UsbDevice _device;
		object _readSync = new object(), _writeSync = new object();
        byte[] _readBuffer, _writeBuffer;

		public LibusbHidStream ()
		{
		}

		internal void Init(HidDevice hidDevice, UsbRegistry registry)
        {
			_hidDevice = hidDevice;
			OpenDevice (registry);
        }

		internal void OpenDevice (UsbRegistry registry)
		{
			this._device = registry.Device;

			IUsbDevice wholeUsbDevice = _device as IUsbDevice;

			if (!ReferenceEquals (wholeUsbDevice, null)) {
				// Select config #1
				wholeUsbDevice.SetConfiguration (1);
				// Claim interface #0.
				wholeUsbDevice.ClaimInterface (0);
			}			
		}

		internal override void HandleFree ()
		{
		}

		public override void Close ()
		{
			if (_device != null && _device.IsOpen) {
			    IUsbDevice wholeUsbDevice = _device as IUsbDevice;
                
				if (!ReferenceEquals(wholeUsbDevice, null))
                {
                    // Release interface #0.
                    wholeUsbDevice.ReleaseInterface(0);
                }

                _device.Close();
			}

			base.Close ();
		}

        public unsafe override void GetFeature(byte[] buffer, int offset, int count)
        {
            Throw.If.OutOfRange(buffer, offset, count);
			
			//HandleAcquireIfOpenOrFail();
			try
			{
				UsbSetupPacket packet = new UsbSetupPacket (0x80 | 0x20, buffer[offset], (short)0x1, 0, 33);

				int transferred;

				_device.ControlTransfer (ref packet, buffer, count, out transferred);
			}
			finally
			{
				//HandleRelease();
			}
        }

        // Buffer needs to be big enough for the largest report, plus a byte
        // for the Report ID.
        public unsafe override int Read(byte[] buffer, int offset, int count)
        {
			throw new NotSupportedException(); // TODO
        }

        public unsafe override void SetFeature(byte[] buffer, int offset, int count)
        {
            Throw.If.OutOfRange(buffer, offset, count);

			//HandleAcquireIfOpenOrFail();
			try
			{
				byte reportId = buffer[offset];

				buffer[offset] = 0;

				IntPtr dat = Marshal.AllocHGlobal(buffer.Length);
				Marshal.Copy(buffer, (int)0, dat, (int)count);

				UsbSetupPacket packet = new UsbSetupPacket(0x20, 0x09, reportId, 0, (byte)buffer.Length);
				int transferred;

				_device.ControlTransfer(ref packet, dat, buffer.Length, out transferred);
			}
			finally
			{
				//HandleRelease();
			}
        }

        public unsafe override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException(); // TODO
        }

        public override HidDevice Device
        {
            get { return _hidDevice; }
        }
	}
}

