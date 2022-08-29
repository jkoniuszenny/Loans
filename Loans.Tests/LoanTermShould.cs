using Loans.Domain.Applications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loans.Tests
{
    public class LoanTermShould
    {

        [Test]
        public void ToMonthsGet12Test()
        {
            LoanTerm loanTerm = new LoanTerm(1);

            var result = loanTerm.ToMonths();

            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void ToMonthsExceptionTest()
        {

            Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void IsYearsEqualToOneTest()
        {
            LoanTerm loanTerm = new LoanTerm(1);
            Assert.That(loanTerm.Years, Is.EqualTo(1));
        }


        [TestCase(5,5)]
       
        public void IsYearsEqualToOneTestByYear(int a, int b)
        {
            LoanTerm loanTerm = new LoanTerm(a);
            LoanTerm loanTerm2 = new LoanTerm(b);

            Assert.That(loanTerm, Is.EqualTo(loanTerm2));
        }

        [TestCase(5, 5)]
        [TestCase(4, 5)]
        public void IsYearsEqualToOneTestByInstance(int a, int b)
        {
            LoanTerm loanTerm = new LoanTerm(a);
            LoanTerm loanTerm2 = new LoanTerm(b);

           // Assert.That(loanTerm, Is.Not.SameAs(loanTerm2));
            LoanTerm loanTerm3 = loanTerm;
            Assert.That(loanTerm, Is.SameAs(loanTerm3));

        }

        [Test]
        public void IsStringEqualToOneAnother()
        {

            List<string> a = new List<string>();
            List<string> b = new List<string>();


          //  Assert.That(a, Is.SameAs(b));
            List<string> c = a;

            Assert.That(a, Is.SameAs(c));

        }
    }
}
