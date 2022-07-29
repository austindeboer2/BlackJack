namespace Test3
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
        public void ScoreTest()
        {
            string win = "You Win.";
            string lose = "You Lose.";
            string tie = "You Tie.";
            
            if(!jack.Score(10,19).Equals(lose)) Assert.Fail("1: There is a problem with your scoring method.");
            else if (!jack.Score(22, 22).Equals(lose)) Assert.Fail("2: There is a problem with your scoring method.");
            else if (!jack.Score(22, 17).Equals(lose)) Assert.Fail("3: There is a problem with your scoring method.");
            else if (!jack.Score(18, 18).Equals(tie)) Assert.Fail("4: There is a problem with your scoring method.");
            else if (!jack.Score(21, 21).Equals(tie)) Assert.Fail("5: There is a problem with your scoring method.");
            else if (!jack.Score(21, 20).Equals(win)) Assert.Fail("6: There is a problem with your scoring method.");
            else if (!jack.Score(10, 22).Equals(win)) Assert.Fail("7: There is a problem with your scoring method.");
            else if (!jack.Score(18, 17).Equals(win)) Assert.Fail("8: There is a problem with your scoring method.");
        }
    }
}