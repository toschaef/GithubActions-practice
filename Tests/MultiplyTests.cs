namespace GithubActionsLab;

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Patino()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "5"));
        Assert.AreEqual(-8, Program.Multiply("-2", "4"));
    }

    [TestMethod]
    public void Multiply_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("x", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "y"));
    }

    [TestMethod]
    public void Multiply_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("2", null));
    }
}
