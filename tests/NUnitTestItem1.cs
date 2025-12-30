using System;
using NUnit.Framework;

namespace ClassFunctions
{
    [TestFixture]
    public class FunctionsTests
    {
        // Тесты для BubbleSort
        [Test]
        public void BubbleSort_SortsArrayCorrectly()
        {
            int[] input = { 5, 3, 8, 1 };
            int[] expected = { 1, 3, 5, 8 };
            Assert.AreEqual(expected, Functions.BubbleSort(input));
        }

        [Test]
        public void BubbleSort_EmptyArray_ReturnsEmpty()
        {
            int[] input = { };
            int[] expected = { };
            Assert.AreEqual(expected, Functions.BubbleSort(input));
        }

        [Test]
        public void BubbleSort_SingleElementArray_ReturnsSameArray()
        {
            int[] input = { 42 };
            int[] expected = { 42 };
            Assert.AreEqual(expected, Functions.BubbleSort(input));
        }

        [Test]
        public void BubbleSort_ArrayWithDuplicates_SortsCorrectly()
        {
            int[] input = { 2, 3, 2, 1 };
            int[] expected = { 1, 2, 2, 3 };
            Assert.AreEqual(expected, Functions.BubbleSort(input));
        }

        // Тесты для IsPalindrome
        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            Assert.IsTrue(Functions.IsPalindrome("madam"));
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            Assert.IsFalse(Functions.IsPalindrome("hello"));
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsFalse()
        {
            Assert.IsFalse(Functions.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsFalse()
        {
            Assert.IsFalse(Functions.IsPalindrome(null));
        }

        // Тесты для Factorial
        [Test]
        public void Factorial_ValidInput_ReturnsCorrectResult()
        {
            Assert.AreEqual(120, Functions.Factorial(5));
        }

        [Test]
        public void Factorial_Zero_ReturnsOne()
        {
            Assert.AreEqual(1, Functions.Factorial(0));
        }

        [Test]
        public void Factorial_One_ReturnsOne()
        {
            Assert.AreEqual(1, Functions.Factorial(1));
        }

        [Test]
        public void Factorial_NegativeInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Functions.Factorial(-1));
        }

        // Тесты для Fibonacci
        [Test]
        public void Fibonacci_FirstPosition_ReturnsZero()
        {
            Assert.AreEqual(0, Functions.Fibonacci(1));
        }

        [Test]
        public void Fibonacci_SecondPosition_ReturnsOne()
        {
            Assert.AreEqual(1, Functions.Fibonacci(2));
        }

        [Test]
        public void Fibonacci_ValidPosition_ReturnsCorrectValue()
        {
            Assert.AreEqual(3, Functions.Fibonacci(5));
        }

        [Test]
        public void Fibonacci_NonPositiveInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Functions.Fibonacci(0));
        }

        // Тесты для ContainsSubstring
        [Test]
        public void ContainsSubstring_SubstringPresent_ReturnsTrue()
        {
            Assert.IsTrue(Functions.ContainsSubstring("hello world", "world"));
        }

        [Test]
        public void ContainsSubstring_SubstringAbsent_ReturnsFalse()
        {
            Assert.IsFalse(Functions.ContainsSubstring("hello world", "planet"));
        }

        [Test]
        public void ContainsSubstring_EmptySubstring_ReturnsTrue()
        {
            Assert.IsTrue(Functions.ContainsSubstring("hello", ""));
        }

        [Test]
        public void ContainsSubstring_NullInput_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => Functions.ContainsSubstring(null, "test"));
            Assert.Throws<ArgumentNullException>(() => Functions.ContainsSubstring("test", null));
        }

        // Тесты для IsPrime
        [Test]
        public void IsPrime_PrimeNumber_ReturnsTrue()
        {
            Assert.IsTrue(Functions.IsPrime(13));
        }

        [Test]
        public void IsPrime_NonPrimeNumber_ReturnsFalse()
        {
            Assert.IsFalse(Functions.IsPrime(15));
        }

        [Test]
        public void IsPrime_OneOrLess_ReturnsFalse()
        {
            Assert.IsFalse(Functions.IsPrime(1));
            Assert.IsFalse(Functions.IsPrime(0));
            Assert.IsFalse(Functions.IsPrime(-5));
        }

        [Test]
        public void IsPrime_Two_ReturnsTrue()
        {
            Assert.IsTrue(Functions.IsPrime(2));
        }

        // Тесты для ReverseInt
        [Test]
        public void ReverseInt_PositiveNumber_ReturnsReversed()
        {
            Assert.AreEqual(321, Functions.ReverseInt(123));
        }

        [Test]
        public void ReverseInt_NegativeNumber_ReturnsReversedWithSign()
        {
            Assert.AreEqual(-321, Functions.ReverseInt(-123));
        }

        [Test]
        public void ReverseInt_NumberWithTrailingZeros_ReturnsReversed()
        {
            Assert.AreEqual(21, Functions.ReverseInt(120));
        }

        [Test]
        public void ReverseInt_Overflow_ReturnsZero()
        {
            // Число, обратный порядок которого превышает int.MaxValue
            int largeNumber = 1534236469;
            Assert.AreEqual(0, Functions.ReverseInt(largeNumber));
        }

        // Тесты для ToRoman
        [Test]
        public void ToRoman_ValidNumber_ReturnsCorrectRoman()
        {
            Assert.AreEqual("MCMXCIV", Functions.ToRoman(1994));
        }

        [Test]
        public void ToRoman_MinValue_ReturnsI()
        {
            Assert.AreEqual("I", Functions.ToRoman(1));
        }

        [Test]
        public void ToRoman_MaxValue_ReturnsCorrectRoman()
        {
            Assert.AreEqual("MMMCMXCIX", Functions.ToRoman(3999));
        }

        [Test]
        public void ToRoman_ZeroOrNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Functions.ToRoman(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => Functions.ToRoman(-5));
        }

        [Test]
        public void ToRoman_AboveMax_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Functions.ToRoman(4000));
        }
    }
}
