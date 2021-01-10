using System;

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
		}

        public static RGBColor FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
                Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
                Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
                Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
                Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
                Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
                Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
            };
    }

    public class RGBColor
    {
        public RGBColor(int i, int i1, int i2)
        {
        }
    }
}