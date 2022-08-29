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
    }
}
