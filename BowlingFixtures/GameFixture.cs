using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;
namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void NoSpareNoStrike()
        {
            Game game = new Game();
            game.Roll(1);
            game.Roll(2);

            game.Roll(3);
            game.Roll(4);

            game.Roll(5);
            game.Roll(4);

            game.Roll(3);
            game.Roll(2);

            game.Roll(1);
            game.Roll(0);

            game.Roll(1);
            game.Roll(2);

            game.Roll(3);
            game.Roll(4);

            game.Roll(5);
            game.Roll(4);

            game.Roll(3);
            game.Roll(2);

            game.Roll(0);
            game.Roll(1);


            System.Diagnostics.Debug.WriteLine("value :" + game.GetScore());
        }

        [TestMethod]
        public void OnlySpare()
        {
            Game game = new Game();
            game.Roll(1);
            game.Roll(9);

            game.Roll(1);
            game.Roll(0);

            game.Roll(3);
            game.Roll(7);

            game.Roll(2);
            game.Roll(0);

            game.Roll(5);
            game.Roll(5);

            game.Roll(3);
            game.Roll(0);

            game.Roll(7);
            game.Roll(3);

            game.Roll(4);
            game.Roll(0);

            game.Roll(9);
            game.Roll(0);

            game.Roll(0);
            game.Roll(1);


            System.Diagnostics.Debug.WriteLine("value :" + game.GetScore());
        }
        [TestMethod]
        public void OnlyStrike()
        {
            Game game = new Game();
            game.Roll(10);


            game.Roll(10);


            game.Roll(10);


            game.Roll(10);


            game.Roll(10);


            game.Roll(10);


            game.Roll(10);


            game.Roll(10);


            game.Roll(10);


            game.Roll(10);

            game.Roll(0);
            game.Roll(0);

            System.Diagnostics.Debug.WriteLine("value :" + game.GetScore());
        }
        [TestMethod]
        public void AllStrike()
        {
            Game game = new Game();
            game.Roll(10);
            game.Roll(10);

            game.Roll(10);
            game.Roll(10);

            game.Roll(10);
            game.Roll(10);

            game.Roll(10);
            game.Roll(10);

            game.Roll(10);
            game.Roll(10);

            game.Roll(10);
            game.Roll(10);

            System.Diagnostics.Debug.WriteLine("value :" + game.GetScore());
        }

        [TestMethod]
        public void Random()
        {
            Game game = new Game();
            game.Roll(1);
            game.Roll(6);

            game.Roll(10);

            game.Roll(5);
            game.Roll(5);

            game.Roll(4);
            game.Roll(5);

            game.Roll(10);

            game.Roll(1);
            game.Roll(1);

            game.Roll(6);
            game.Roll(4);

            game.Roll(10);

            game.Roll(0);
            game.Roll(10);

            game.Roll(10);

            game.Roll(5);
            game.Roll(5);

            System.Diagnostics.Debug.WriteLine("value :" + game.GetScore());
        }
    }
}
