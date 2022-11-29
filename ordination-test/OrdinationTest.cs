namespace ordination_test;

using shared.Model;

[TestClass]
public class OrdinationTest
{

    [TestMethod]
    public void AntalDageTest()
    {
        // Gyldig data
        // TC1:
        PN tc1 = new PN(new DateTime(2022, 11, 20), new DateTime(2022, 11, 23), 123, new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml"));

        int antalDage_tc1 = tc1.antalDage();

        Assert.AreEqual(3, antalDage_tc1);

        // TC2:
        PN tc2 = new PN(new DateTime(2022, 11, 20), new DateTime(2022, 11, 20), 123, new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml"));

        int antalDage_tc2 = tc2.antalDage();

        Assert.AreEqual(0, antalDage_tc2);


        // Ugyldig data
        // TC3:
        PN tc3 = new PN(new DateTime(2022, 11, 23), new DateTime(2022, 11, 20), 123, new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml"));

        int antalDage_tc3 = tc3.antalDage();

        Assert.AreEqual(-1, antalDage_tc3);
    }
}