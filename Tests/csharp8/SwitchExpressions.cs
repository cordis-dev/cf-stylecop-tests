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
			
			string errorReason = user.IsAbove(bot) switch
            {
                _ when isBot => "I wish I could kick myself, but I sadly cannot.",
                _ => "Something has gone really wrong, and I don't know what *:(*"
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
    }

    public class RGBColor
    {
        public RGBColor(int i, int i1, int i2)
        {
        }
    }
}