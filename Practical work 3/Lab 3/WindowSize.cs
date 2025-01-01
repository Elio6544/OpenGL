namespace Lab_3
{
    public struct WindowSize
    {
        public float Xmin;
        public float Xmax;

        public float Ymin;
        public float Ymax; 

        public WindowSize(float Xmin, float Xmax, float Ymin, float Ymax)
        {
            this.Xmin = Xmin;
            this.Xmax = Xmax;

            this.Ymin = Ymin;
            this.Ymax = Ymax;
        }
    }
}
