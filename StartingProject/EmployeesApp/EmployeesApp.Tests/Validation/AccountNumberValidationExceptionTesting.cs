using EmployeesApp.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Tests.Validation
{
    public class AccountNumberValidationExceptionTesting
    {
        private readonly AccountNumberValidation _validation;
        public AccountNumberValidationExceptionTesting()
        {
            _validation = new AccountNumberValidation();
        }

        [Theory]
        [InlineData("123-345456567633=23")]
        [InlineData("123+345456567633-23")]
        [InlineData("123+345456567633=23")]
        public void IsValid_InvalidDelimiters_ThrowsArgumentException(string accNumber)
        {
            Assert.Throws<ArgumentException>(() => _validation.IsValid(accNumber));
        }
    }
    }
