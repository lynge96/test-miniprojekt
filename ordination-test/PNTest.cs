namespace ordination_test;

using shared.Model;

[TestClass]
public class PNTest
{

    [TestMethod]
    public void GivDosisTest()
    {
        // Gyldig data
        // TC1:
        PN tc1 = new PN(new DateTime(2021, 1, 1), new DateTime(2021, 1, 12), 123, new Laegemiddel("Acetylsalicylsyre", 0.1, 0.15, 0.16, "Styk"));

        bool givDosis_tc1 = tc1.givDosis(new Dato { dato = new DateTime(2021, 1, 5).Date });

        Assert.AreEqual(true, givDosis_tc1);

        // TC2:
        PN tc2 = new PN(new DateTime(2021, 1, 1), new DateTime(2021, 1, 12), 123, new Laegemiddel("Acetylsalicylsyre", 0.1, 0.15, 0.16, "Styk"));

        bool givDosis_tc2 = tc2.givDosis(new Dato { dato = new DateTime(2021, 1, 1).Date });
        
        Assert.AreEqual(true, givDosis_tc2);

        // TC3:
        PN tc3 = new PN(new DateTime(2021, 1, 1), new DateTime(2021, 1, 12), 123, new Laegemiddel("Acetylsalicylsyre", 0.1, 0.15, 0.16, "Styk"));

        bool givDosis_tc3 = tc3.givDosis(new Dato { dato = new DateTime(2021, 1, 12).Date });

        Assert.AreEqual(true, givDosis_tc3);


        // Ugyldig data
        // TC4:
        PN tc4 = new PN(new DateTime(2021, 1, 1), new DateTime(2021, 1, 12), 123, new Laegemiddel("Acetylsalicylsyre", 0.1, 0.15, 0.16, "Styk"));

        bool givDosis_tc4 = tc3.givDosis(new Dato { dato = new DateTime(2020, 12, 31).Date });

        Assert.AreEqual(false, givDosis_tc4);

        // TC5:
        PN tc5 = new PN(new DateTime(2021, 1, 1), new DateTime(2021, 1, 12), 123, new Laegemiddel("Acetylsalicylsyre", 0.1, 0.15, 0.16, "Styk"));

        bool givDosis_tc5 = tc5.givDosis(new Dato { dato = new DateTime(2021, 1, 13).Date });

        Assert.AreEqual(false, givDosis_tc5);

    }
}