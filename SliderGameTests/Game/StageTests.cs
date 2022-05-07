using Xunit;
using SliderGame.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliderGame.Game.Tests
{
    public class StageTests
    {

        [Fact()]
        public void ExecuteTurnTest()
        {
            var slider1 = new Slider(5, 3, false);
            var slider2 = new Slider(7, 4, true);
            var slider3 = new Slider(3, 2, false);
            var slider4 = new Slider(4, 3, true);

            var listOfSliders = new List<Slider>()
                                                {
                                                    slider1, slider2, slider3, slider4,
                                                };


            var game = new Stage(listOfSliders);

            game.ExecuteTurn(0);
            Assert.True(game.listOfSliders[0].currPosition == 3,  "1 incorrect position");
            Assert.True(game.listOfSliders[0].direction == false, "2 incorrect position");
            Assert.True(game.listOfSliders[1].currPosition == 5,  "3 incorrect position");
            Assert.True(game.listOfSliders[1].direction == true,  "4 incorrect position");
            Assert.True(game.listOfSliders[2].currPosition == 1,  "5 incorrect position");
            Assert.True(game.listOfSliders[2].direction == true, "6 incorrect position");
            Assert.True(game.listOfSliders[3].currPosition == 4,  "7 incorrect position");
            Assert.True(game.listOfSliders[3].direction == false, "8 incorrect position");



        }

        [Fact()]
        public void IsWinningTest()
        {
            var slider1 = new Slider(5, 3, true);
            var slider2 = new Slider(5, 3, true);
            var slider3 = new Slider(5, 3, true);
            var slider4 = new Slider(5, 4, true);
            
            var listOfSliders = new List<Slider>()
                                                {
                                                    slider1, slider2, slider3, slider4,
                                                };

            var game = new Stage(listOfSliders);

            game.ExecuteTurn(3);

            Assert.True(game.IsWinning() == true, "The game should be in winning position");
        }
    }
}