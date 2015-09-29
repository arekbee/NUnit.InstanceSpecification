using System;
using NUnit.Framework;

namespace NUnit.InstanceSpecification
{
	public abstract class InstanceSpecification_for_ICloneable<TSubjectUnderTest> : InstanceSpecification<TSubjectUnderTest>
		where TSubjectUnderTest : ICloneable
	{

		[Test]
		public void Subject_under_test_should_()
		{
			var clone = SubjectUnderTest.Clone();
			Assert.IsNotNull(clone);
			Assert.AreEqual(SubjectUnderTest, clone);
		}
	}
}

