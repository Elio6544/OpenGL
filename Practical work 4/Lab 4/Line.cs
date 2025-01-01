namespace Lab_4
{
    public struct Line
    {
        public PointLine point_1;
        public PointLine point_2;

        public Line(PointLine point_1, PointLine point_2)
        {
            this.point_1 = point_1;
            this.point_2 = point_2;
        }
    }
}
