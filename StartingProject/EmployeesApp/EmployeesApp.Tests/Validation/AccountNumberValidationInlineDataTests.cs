using EmployeesApp.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Tests.Validation
{
    public class AccountNumberValidationInlineDataTests
    {
        private readonly AccountNumberValidation _validation;
        public AccountNumberValidationInlineDataTests()
        {
            _validation = new AccountNumberValidation();
        }

        [Theory]
        [InlineData("1234-3454565676-23")]
        [InlineData("12-3454565676-23")]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse(string accountNumber)
        {
            Assert.False(_validation.IsValid(accountNumber));
        }

    }
}
