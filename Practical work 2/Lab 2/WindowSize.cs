namespace Lab_2
{
    public struct WindowSize
    {
        public float Xmin, Xmax;
        public float Ymin, Ymax;

        public WindowSize(float Xmin, float Xmax, float Ymin, float Ymax)
        {
            this.Xmin = Xmin;
            this.Xmax = Xmax;

            this.Ymin = Ymin;
            this.Ymax = Ymax;
        }
    }
}
