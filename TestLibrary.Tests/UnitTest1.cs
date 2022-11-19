using TestLibrary;
namespace TestLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InputOneValue_WidthValidCount()
        {
            //Arange
            double expected = Math.PI;
            FigureBuilder builder = new FigureBuilder(1);
            IFigure figure = builder.GetFigure();
            //Act
            var actual = figure.Square();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InputThreeValue_WidthValidCount()
        {
            //Arange
            double expected = 6;
            FigureBuilder builder = new FigureBuilder(3, 4, 5);
            IFigure figure = builder.GetFigure();
            //Act
            var actual = figure.Square();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InputValue_WidthInvalidCount()
        {
            //Arange
            FigureBuilder builder = new FigureBuilder(3, 4, 5, 6, 7);
            //Act
            IFigure figure = builder.GetFigure();
            //Assert
            Assert.IsNull(figure);
        }
    }
}