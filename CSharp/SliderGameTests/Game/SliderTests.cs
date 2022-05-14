using Xunit;
using SliderGame.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliderGame.Game.Tests
{
    public class SliderTests
    {
        [Fact()]
        public void SliderTest()
        {
            // Test basic functionality of constructor
            var sliderOne = new Slider(5, 3, true);

            Assert.True(sliderOne.height == 5, "The constructor for slider does not assign height correctly");
            Assert.True(sliderOne.currPosition == 3, "The constructor for slider does not assign currPosition correctly");
            Assert.True(sliderOne.direction == true, "The constructor for slider does not assign direction correctly");

            // Create objects that are not valid

            var sliderNotValid1 = new Slider(5, 7, true);
            Assert.True((sliderNotValid1.currPosition == 5 && sliderNotValid1.direction == false), "sliderNotValid1 unexepected result");

            var sliderNotValid2 = new Slider(5, -3, true);

            Assert.True((sliderNotValid2.currPosition == 1 && sliderNotValid2.direction == true), "sliderNotValid2 unexepected result");

            var sliderNotValid3 = new Slider(5, 5, true);
            Assert.True((sliderNotValid3.currPosition == 5 && sliderNotValid3.direction == false), "sliderNotValid3 unexepected result");

            var sliderNotValid4 = new Slider(5, 0, false);
            Assert.True((sliderNotValid4.currPosition == 1 && sliderNotValid4.direction == true), "sliderNotValid4 unexepected result");

            var sliderNotValid5 = new Slider(5);
            Assert.True((sliderNotValid5.currPosition <= 5 && sliderNotValid5.currPosition >= 1), "sliderNotValid5 unexepected result");
        }

        [Fact()]
        public void NextTest()
        {

            // Test basic functionality of constructor
            var slider1 = new Slider(5, 3, true);
            slider1.Next();
            Assert.True((slider1.currPosition == 4 && slider1.direction == true), "slider1 Incorrect");


            var slider2 = new Slider(5, 3, false);
            slider2.Next();
            Assert.True((slider2.currPosition == 2 && slider2.direction == false), "slider2 Incorrect");


            var slider3 = new Slider(5, 5, false);
            slider3.Next();
            Assert.True((slider3.currPosition == 4 && slider3.direction == false), "slider3 Incorrect");


            var slider4 = new Slider(5, 0, true);
            slider4.Next();
            Assert.True((slider4.currPosition == 1 && slider4.direction == true), "slider4 Incorrect");
        }

        [Fact()]
        public void PrintSelfTest()
        {
            var slider1 = new Slider(5, 3, true);

            string output = slider1.PrintSelf();
            Assert.True(output == "-->--", "1 incorrect");
            slider1.Next();
            output = slider1.PrintSelf();
            Assert.True(output == "--->-", "2 incorrect");
            slider1.Next();
            output = slider1.PrintSelf();
            Assert.True(output == "----<", "3 incorrect");
            slider1.Next();
            output = slider1.PrintSelf();
            Assert.True(output == "---<-", "4 incorrect");
            slider1.Next();
            output = slider1.PrintSelf();
            Assert.True(output == "--<--", "5 incorrect");
            slider1.Next();
            output = slider1.PrintSelf();
            Assert.True(output == "-<---", "6 incorrect");
            slider1.Next();
            output = slider1.PrintSelf();
            Assert.True(output == ">----", "7 incorrect");
            slider1.Next();
            output = slider1.PrintSelf();
            Assert.True(output == "->---", "8 incorrect");
        }
    }
}