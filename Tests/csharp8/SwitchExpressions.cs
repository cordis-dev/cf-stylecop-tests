using System;
using System.IO;

namespace Tests
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public enum Directions
    {
        Up,
        Down,
        Right,
        Left
    }

    public enum Orientation
    {
        North,
        South,
        East,
        West
    }

    public class SETests
    {
        private IVirtualMouse pointer => Info.Driver.OutputMode switch
        {
            IPointerOutputMode<IRelativePointer> outputMode => outputMode.Pointer as IVirtualMouse,
            IPointerOutputMode<IAbsolutePointer> outputMode => outputMode.Pointer as IVirtualMouse,
            _ => null
        };

        private static string SwitchInsideGet
        {
            get
            {
                var z = SI.CurrentPlatform switch
                {
                    PP.MacOS => "AA",
                    _ => null
                };

                return "BB";
            }
        }

        public void T()
		{
			switch (attr)
			{
				case ExperimentalAttribute _:
				case ParameterAttribute param when param.ToHide:
					break;
				default:
					break;
			}
			
            var direction = Directions.Right;
            var orientation = direction switch
			{
				Directions.Up    => Orientation.North,
				Directions.Right => Orientation.East,
				Directions.Down  => Orientation.South,
				Directions.Left  => Orientation.West,
			};
			
			string errorReason = user.IsAbove(bot) switch
            {
                _ when isBot => "I wish I could kick myself, but I sadly cannot.",
                _ => "Something has gone really wrong, and I don't know what *:(*"
            };
			
			(ConsoleColor foreground, ConsoleColor background) = style switch
            {
                ConsoleThemeStyle.LevelVerbose => ConsoleColor.Magenta, 
                _ => ConsoleColor.Gray
            };
		}

        public static RGBColor FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
                Rainbow.Orange or Rainbow.Blue or Rainbow.AA => new RGBColor(0xFF, 0x7F, 0x00),
                Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
            };

        private static string ToDllName(string dllName)
        {
            return SystemInterop.CurrentPlatform switch
            {
                PluginPlatform.Windows => $"{dllName}.dll",
                PluginPlatform.Linux => $"lib{dllName}.so",
                PluginPlatform.MacOS => $"lib{dllName}.dylib",
                _ => null
            };
        }

        public readonly static bool EnableTrayIcon = SystemInterop.CurrentPlatform switch
        {
            PluginPlatform.Windows => true,
            PluginPlatform.MacOS => true,
            _ => false
        };

        public static void T()
        {
            messageList.KeyDown += (sender, e) =>
            {
                switch (e.Modifiers, e.Key)
                {
                    case (Keys.Control, Keys.C):
                    {
                        copyCommand.Execute();
                        break;
                    }
                }
            };
        }

        public virtual IDeviceReport Parse(byte[] data)
        {
            return data[0] switch
            {
                0x2 => new IntuosV2TabletReport(data),
                0x10 => new IntuosV2TabletReport(data),
                0x3 => new IntuosV2AuxReport(data),
                _ => new DeviceReport(data)
            };
        }

        private static Lazy<IAbsolutePointer> _absolutePointer = new Lazy<IAbsolutePointer>(() => CurrentPlatform switch
        {
            PluginPlatform.Windows => new WindowsAbsolutePointer(),
            PluginPlatform.MacOS => new MacOSAbsolutePointer(),
            _ => null
        });
    }

    public class RGBColor
    {
        public RGBColor(int i, int i1, int i2)
        {
        }
    }
}