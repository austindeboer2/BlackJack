namespace Test2
{
    public class Tests
    {
        BlackJack jack;

        [SetUp]
        public void Setup()
        {
            jack = new BlackJack();
        }

        [Test]
        public void ComputerRoundTests()
        {
            int clean = 0;
            int bust = 0;
            for (int i = 0; i < 10000000; i++)
            {
                int computer = jack.ComputerRound();
                if (computer >= 17 && computer <= 21) clean++;
                else bust++;
            }
            int total = bust + clean;
            float busted = (float)bust / (float)total;

            if (busted > .36f && busted < .45f) Assert.Pass();
            else Assert.Fail("There is a problem with the way you are giving the computer thier cards. Consult your ComputerRound method.");
        }
    }
}