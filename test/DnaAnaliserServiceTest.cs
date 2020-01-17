using src.domain;
using Xunit;

namespace test
{
    public class DnaAnaliserServiceTest
    {
        [Fact]
        public void GivenASimianDnaChainWhenDetectSimianSequenceThenReturnThatIsSimian()
        {
        //Given
        string[,] dnaChain = {
            {"C","T","G","A","G","A"},
            {"C","T","A","T","C","G"},
            {"T","A","T","T","G","T"},
            {"A","G","A","G","G","G"},
            {"C","C","C","C","T","A"},
            {"T","C","A","C","T","G"}
        };
        //When
          bool isSimian = DnaAnaliserService.isSimian(dnaChain);
        //Then
        Assert.True(isSimian);
        }

        [Fact]
        public void GivenAHumanDnaChainWhenDetectSimianSequenceThenReturnThatIsNotSimian()
        {
            //Given
            string[,] dnaChain = {
                {"A","T","G","C","G","A"},
                {"C","A","G","T","G","C"},
                {"T","T","A","T","T","T"},
                {"A","G","A","C","G","G"},
                {"G","C","G","T","C","A"},
                {"T","C","A","C","T","G"}
            };
            //When
            bool isSimian = DnaAnaliserService.isSimian(dnaChain);

            //Then
            Assert.False(isSimian);
        }
    }
}
