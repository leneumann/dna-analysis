using domain;
using Xunit;

namespace test
{
    public class DnaAnalizerTest
    {
        [Fact]
        public void GivenValidDnaChainWhenNotFoundFourEqualProteinsDiagonallyThenReturnZero()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","T","G","A"},
            {"C","T","A","C","C","G"},
            {"T","A","T","T","G","T"},
            {"A","G","A","T","G","G"},
            {"C","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeDiagonally(dnaChain);
            //Then
            Assert.Equal(0, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenFoundFourEqualProteinsDiagonallyThenReturnTotalOfChainsFound()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","A","G","A"},
            {"C","T","A","T","C","G"},
            {"T","A","T","T","G","T"},
            {"A","G","A","T","G","G"},
            {"C","C","T","C","T","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeDiagonally(dnaChain);
            //Then
            Assert.Equal(1, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenFoundTwoChainsWithFourEqualProteinsDiagonallyThenReturnTotalOfChainsFound()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","A","G","A"},
            {"C","T","A","T","C","A"},
            {"T","A","T","T","A","T"},
            {"A","G","A","A","G","G"},
            {"C","C","A","A","T","A"},
            {"T","C","A","C","A","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeDiagonally(dnaChain);
            //Then
            Assert.Equal(2, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenNotFoundFourEqualProteinsDiagonallyInvertedThenReturnZero()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","T","G","A"},
            {"C","T","A","C","C","G"},
            {"T","A","T","T","G","T"},
            {"A","G","A","T","G","G"},
            {"C","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeDiagonallyInverted(dnaChain);
            //Then
            Assert.Equal(0, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenFoundFourEqualProteinsDiagonallyInverseThenReturnTotalOfChains()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","A","G","A"},
            {"C","T","A","G","C","G"},
            {"T","G","A","T","G","T"},
            {"A","T","A","T","G","G"},
            {"T","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeDiagonallyInverted(dnaChain);
            //Then
            Assert.Equal(1, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenFoundTwoChainsOfFourEqualProteinsDiagonallyInverseThenReturnTotalOfChains()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","A","G","A"},
            {"C","T","T","G","C","G"},
            {"T","G","A","T","G","T"},
            {"A","T","A","T","T","G"},
            {"T","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeDiagonallyInverted(dnaChain);
            //Then
            Assert.Equal(2, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenNotFoundFourEqualProteinsHorizontallyThenReturnZero()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","T","G","A"},
            {"C","T","A","C","C","G"},
            {"T","A","T","T","G","T"},
            {"A","G","A","T","G","G"},
            {"C","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeHorizontally(dnaChain);
            //Then
            Assert.Equal(0, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenFoundFourEqualProteinsHorizontallyThenReturnTotalOfChainsFound()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","A","G","A"},
            {"C","T","G","A","C","G"},
            {"T","A","A","A","A","T"},
            {"A","T","A","T","G","G"},
            {"T","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeHorizontally(dnaChain);
            //Then
            Assert.Equal(1, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenFoundTwoOrMoreChainsWithFourEqualProteinsHorizontallyThenReturnTotalOfChainsFound()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","A","G","A"},
            {"C","T","G","A","C","G"},
            {"T","A","A","A","A","T"},
            {"A","T","A","T","G","G"},
            {"T","T","T","T","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeHorizontally(dnaChain);
            //Then
            Assert.Equal(2, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenNotFoundFourEqualProteinsVerticallyThenReturnZero()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","T","G","A"},
            {"C","T","A","C","C","G"},
            {"T","A","T","T","G","T"},
            {"A","G","A","T","G","G"},
            {"C","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeVertically(dnaChain);
            //Then
            Assert.Equal(0, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenFoundFourEqualProteinsVerticallyThenReturnTotalOfSequencesFound()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","T","G","A"},
            {"C","T","A","T","C","G"},
            {"T","A","T","T","G","T"},
            {"A","G","A","T","G","G"},
            {"C","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeVertically(dnaChain);
            //Then
            Assert.Equal(1, totalOfChainsFound);
        }

        [Fact]
        public void GivenValidDnaChainWhenFoundMoreThanOneSequenceOfFourEqualProteinsVerticallyThenReturnTotalOfSequencesFound()
        {
            //Given
            string[,] dnaChain = {
            {"C","T","G","T","G","A"},
            {"C","T","A","T","G","G"},
            {"T","A","T","T","G","T"},
            {"A","G","A","T","G","G"},
            {"C","C","T","C","A","A"},
            {"T","C","A","C","T","G"}
        };
            //When
            int totalOfChainsFound = DnaAnalizer.AnalizeVertically(dnaChain);
            //Then
            Assert.Equal(2, totalOfChainsFound);
        }
    }
}