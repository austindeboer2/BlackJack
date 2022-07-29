namespace Test1
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
        public void NewCardTests()
        {
            int[] numbers = new int[10];
            for(int i = 0; i < 10000000; i++)
            {
                int card = jack.NewCard();
                if (card == 1) numbers[1] += 1;
                else if (card == 2) numbers[2] += 1;
                else if (card == 3) numbers[3] += 1;
                else if (card == 4) numbers[4] += 1;
                else if (card == 5) numbers[5] += 1;
                else if (card == 6) numbers[6] += 1;
                else if (card == 7) numbers[7] += 1;
                else if (card == 8) numbers[8] += 1;
                else if (card == 9) numbers[9] += 1;
                else if (card == 10) numbers[0] += 1;
                else Assert.Fail("You have given a card number that has fallen outside of the acceptable parameters. Consult your NewCard Function.");
            }
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum+=numbers[i];
            }
            sum -= numbers[0];
            float percentTen = ((float)numbers[0] / (float)sum);
            if (percentTen > .25f && percentTen < .5f) Assert.Pass();
            else Assert.Fail("Something has gone wrong with the percentage of 10's you are dealing. Consult your NewCard Function.");
        }
    }
}