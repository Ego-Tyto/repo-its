namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {           
            Calcolatricelib.calcolatrice calcolatrice = new Calcolatricelib.calcolatrice();
            double risultato = calcolatrice.somma(2, 3);
            Assert.AreEqual(5, risultato,"La somma di 2 e 3 dovrebbe essere 5");
        }   
        [TestMethod]
        public void Testsommaconzero() {
            Calcoltrice calcoltrice = new Calcoltrice();
            double risultato = calcoltrice.somma(0, 3);
            Assert.AreEqual(3, risultato, "La somma di 0 e 3 dovrebbe essere 3");    
        }
}  
