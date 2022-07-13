using AgeGroupMeasurement1;
using FluentAssertions;
using NUnit.Framework;

namespace AgeGroupMeasurementTests
{
    public class AgeGroupYoungAdultTest
    {
        [TestCase(20)]
        [TestCase(24)]
        public void PersonBetween20To24YearOldsIsAYoungAdult(int age)
        {
            new AgeGroupYoungAdult().Range(age).Should().BeTrue();
        }

        [TestCase(19)]
        [TestCase(25)]
        public void PersonUnder20OrOver24YearOldsIsNotAYoungAdult(int age)
        {
            new AgeGroupYoungAdult().Range(age).Should().BeFalse();
        }
    }
}