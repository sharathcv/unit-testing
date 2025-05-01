using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullName_GivenFirstNameLastName_ReturnsFullName()
        {
            var names = new Names();
            var fullName = names.MakeFullName("Sharath", "Valoth");

            Assert.Equal("Sharath Valoth", fullName);
        }

        [Fact]
        public void MakeFullName_GivenFirstNameLastName_MatchesRegex()
        {
            var names = new Names();
            var fullName = names.MakeFullName("Sharath", "Valoth");

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", fullName);
        }

        [Fact]
        public void MakeFullName_GivenFirstNameLastName_FirsNameExists()
        {
            var names = new Names();
            var fullName = names.MakeFullName("Sharath", "Valoth");

            // Assert.StartsWith() is another option
            Assert.Contains("sharath", fullName, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
