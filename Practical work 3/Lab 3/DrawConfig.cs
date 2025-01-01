namespace Lab_3
{
    public struct DrawConfig
    {
        public float width;
        public float height;

        public float margin;
        public float step;

        public DrawConfig(float width, float height, float margin, float step)
        {
            this.width = width;
            this.height = height;

            this.margin = margin;   
            this.step = step;
        }
    }
}
