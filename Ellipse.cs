namespace Travel
{
    public class Ellipse
    {
        public int MajorAxis { get; set; }
        public int MinorAxis { get; set; }

        public Ellipse(int majorAxis, int minorAxis)
        {
            if (majorAxis <= minorAxis)
            {
                throw new ArgumentException("ERROR!");
            }

            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }

        public double GetSquare()
        {
            return Math.Round(MinorAxis * MajorAxis * Math.PI);
        }

        public double GetLength()
        {
            return Math.Round((MinorAxis + MajorAxis) * Math.PI);
        }
    }
}