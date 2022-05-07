namespace SliderGame.Game;
public class Slider
{
    public int height;
    public int currPosition;
    public bool direction;

    public Slider(int height, int currPosition, bool direction)
    {
        this.height = height;
        this.currPosition = currPosition;
        this.direction = direction;
    }

    public Slider(int height)
    {
        this.height = height;
        this.currPosition = 0;
        this.direction = true;
    }

    public void Next()
    {
        throw new NotImplementedException();
    }
}
