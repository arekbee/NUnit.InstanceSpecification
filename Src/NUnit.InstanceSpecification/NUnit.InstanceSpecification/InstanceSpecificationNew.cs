using System;
using NUnit.Framework;

namespace NUnit.InstanceSpecification
{
	public abstract class InstanceSpecificationNew<TSubjectUnderTest> : InstanceSpecification<TSubjectUnderTest>
		where TSubjectUnderTest : new()
	{
		protected override TSubjectUnderTest Create_subject_under_test()
		{
			return new TSubjectUnderTest();
		}

		[Test]
		public void Subject_under_test_should_not_be_null()
		{
			Assert.IsNotNull(SubjectUnderTest, "Object is null. Check method Create_subject_under_test in InstanceSpecification");
		}
	}
}

