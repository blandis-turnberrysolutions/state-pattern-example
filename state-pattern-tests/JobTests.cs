using System;
using NUnit.Framework;
using state_pattern_lib;

namespace state_pattern_tests
{
    public class JobTests
    {
        [Test]
        public void OpenWhenClosed()
        {
           var subject = new Job(JobStates.Closed);

            subject.Open();

            Assert.That(subject.State, Is.EqualTo(JobStates.Open));
        }

        [Test]
        public void OpenWhenOpenThrowsException()
        {
           var subject = new Job(JobStates.Open);

            Assert.That(() => subject.Open(), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void CloseWhenOpen()
        {
            var subject = new Job(JobStates.Open);

            subject.Close();

            Assert.That(subject.State, Is.EqualTo(JobStates.Closed));
        }

        [Test]
        public void CloseWhenClosedThrowsException()
        {
            var subject = new Job(JobStates.Closed);

            Assert.That(() => subject.Close(), Throws.TypeOf<InvalidOperationException>());
        }
    }
}