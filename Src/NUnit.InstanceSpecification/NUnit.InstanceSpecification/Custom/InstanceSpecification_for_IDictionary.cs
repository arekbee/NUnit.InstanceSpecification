using System;
using NUnit.Framework;

namespace NUnit.InstanceSpecification
{
	public abstract class InstanceSpecification_for_IDictionary<TSubjectUnderTest, TKey, TValue> : InstanceSpecification<TSubjectUnderTest>
		where TSubjectUnderTest : IDictionary<TKey, TValue>
	{
		public TKey DefaultKey = default(TKey);
		public TValue DefaultValue = default(TValue);



		[Test]
		public void Subject_under_test_should_thorw_eception_because_adding_same_key()
		{
			SubjectUnderTest.Add(DefaultKey, DefaultValue);
			Assert.Throws<ArgumentException>(()=>SubjectUnderTest.Add(DefaultKey, DefaultValue));
		}

		[Test]
		public void Subject_under_test_shold_throw_exception_because_null_key()
		{
			//Assert.Throws<ArgumentException>(() => SubjectUnderTest.Add(, DefaultValue));
		}
	}
}

