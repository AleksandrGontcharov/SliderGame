namespace SliderGame.Game;
public class Stage
{
    public List<Slider> listOfSliders;

    public Stage(List<Slider> listOfSliders)
    {
        if (listOfSliders.Count < 2)
        {
            throw new ArgumentException("Ensure that you provide a list of at least 2 sliders for this Stage.");
        }
        this.listOfSliders = listOfSliders;
    }

    public void ExecuteTurn(int index)
    {
        int i = 0;

        for (i = 0; i < this.listOfSliders.Count; i++)
        {
            if (index != i) { 
                this.listOfSliders[i].Next();
            }
        }
    }

    public bool IsWinning()
    {
        int firstCurrPosition = this.listOfSliders[0].currPosition;
        bool isWinning = true;

        for (int i = 1; i < this.listOfSliders.Count; i++)
        {
            if (firstCurrPosition != this.listOfSliders[i].currPosition)
            {
                isWinning = false;
                return isWinning;
            }
        }

        return isWinning;
    }

    public void Print()
    {
        Console.WriteLine("Implement the printing later");
    }

}
