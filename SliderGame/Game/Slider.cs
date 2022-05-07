namespace SliderGame.Game;
public class Slider
{
    public int height;
    public int currPosition;
    public bool direction;

    public Slider(int height, int currPosition, bool direction)
    {
        constructorHelper(height, currPosition, direction);
    }

    public Slider(int height)
    {
        Random r = new Random();
        int currPosition = r.Next(0, height); // "random number between 0 and height"
        constructorHelper(height, currPosition, false);
    }

    void constructorHelper(int height, int currPosition, bool direction)
    {
        if (currPosition >= height)
        {
            currPosition = height;
            direction = false;
        }
        else if (currPosition <= 1)
        {
            currPosition = 1;
            direction = true;
        }

        this.height = height;
        this.currPosition = currPosition;
        this.direction = direction;
    }

    public void Next()
    {
        // edge cases
        if (currPosition == this.height)
        {
            this.currPosition = currPosition - 1;
            this.constructorHelper(this.height, currPosition, false);

        }
        else if (currPosition == 1)
        {
            this.currPosition = currPosition + 1;
            this.constructorHelper(this.height, currPosition, true);
        }
        else
        { // in the middle of the slider
            if (direction)
            {
                this.currPosition = currPosition + 1;
                this.constructorHelper(this.height, currPosition, true);
            }
            else
            {
                this.currPosition = currPosition - 1;
                this.constructorHelper(this.height, currPosition, false);
            }
        }
    }


    public string PrintSelf()
    {
        string[] result = Enumerable.Repeat("-", this.height).ToArray();

        string arrowRight = ">";
        string arrowLeft = "<";



        // edge cases
        if (currPosition == this.height)
        {
            result[this.currPosition - 1] = arrowLeft;
        }
        else if (currPosition == 1)
        {
            result[this.currPosition - 1] = arrowRight;
        }
        else
        { // in the middle of the slider
            if (direction)
            {
                result[this.currPosition - 1] = arrowRight;
            }
            else
            {
                result[this.currPosition - 1] = arrowLeft;
            }
        }


        string output = string.Join("", result);

        Console.WriteLine(output);

        return output;
    }

}
