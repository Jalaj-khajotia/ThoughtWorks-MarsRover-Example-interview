using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverTest
    {
        private MarsRover.MarsRover rover;
        public MarsRoverTest()
        {
            Plateau plateau = new Plateau(5, 5);
            CoOrdinates startingPosition = new CoOrdinates(3, 3);
            Direction dir = new Direction() { currentDirection = Direction.dir.E };
            rover = new MarsRover.MarsRover(dir, plateau, startingPosition);
        }

        [TestMethod]
        public void canProvideCurrentLocationAsString()
        {
            Assert.AreEqual("3 3 E", rover.currentLocation());
        }

        [TestMethod]
        public void canRotateLeft()
        {
            rover.turnLeft();
            Assert.AreEqual("3 3 N", rover.currentLocation());
        }

        [TestMethod]
        public void canRotateRight()
        {
            rover.turnRight();
            Assert.AreEqual("3 3 S", rover.currentLocation());
        }
        [TestMethod]
        public void canMove()
        {
            rover.Move();
            //then
            Assert.AreEqual("4 3 E", rover.currentLocation());
        }

        [TestMethod]
        public void canTakeCommands()
        {
            rover.run("R");
            //then
            Assert.AreEqual("3 3 S", rover.currentLocation());
        }

        [TestMethod]
        public void canRunCommandWithMultipleInstructions()
        {

            //When
            rover.run("MMRMMRMRRM");

            //then
            Assert.AreEqual("5 1 E", rover.currentLocation());
        }
    }
}
