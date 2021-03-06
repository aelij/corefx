// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Globalization.Tests
{
    public class DateTimeFormatInfoAbbreviatedMonthNames
    {
        [Fact]
        public void AbbreviatedMonthNames_InvariantInfo()
        {
            Assert.Equal(new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", "" }, DateTimeFormatInfo.InvariantInfo.AbbreviatedMonthNames);
        }

        [Fact]
        public void AbbreviatedMonthNames_Set()
        {
            string[] newAbbreviatedMonthNames = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "" };
            var format = new DateTimeFormatInfo();
            format.AbbreviatedMonthNames = newAbbreviatedMonthNames;
            Assert.Equal(newAbbreviatedMonthNames, format.AbbreviatedMonthNames);
        }

        [Fact]
        public void AbbreviatedMonths_Set_Invalid()
        {
            Assert.Throws<ArgumentNullException>(() => new DateTimeFormatInfo().AbbreviatedMonthNames = null); // Value is null
            Assert.Throws<ArgumentNullException>(() => new DateTimeFormatInfo().AbbreviatedMonthNames = new string[] { "1", "2", "3", null, "5", "6", "7", "8", "9", "10", "11", "12", "" }); // Value has null
            Assert.Throws<ArgumentException>(() => new DateTimeFormatInfo().AbbreviatedMonthNames = new string[] { "Jan" }); // Value.Length is not 13

            // DateTimeFormatInfo.InvariantInfo is read only
            Assert.Throws<InvalidOperationException>(() => DateTimeFormatInfo.InvariantInfo.AbbreviatedMonthNames = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "" });
        }
    }
}
