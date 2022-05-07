namespace SliderGame.Game;
public class Stage
{
    List<Slider> listOfSliders;

    public Stage(List<Slider> listOfSliders)
    {
        this.listOfSliders = listOfSliders;
    }

    public void ExecuteTask(int index)
    {
        throw new NotImplementedException();
    }

    public bool IsWinning()
    {
        return false;
    }

    public void Print()
    {
        Console.WriteLine("Implement the printing later");
    }

}
