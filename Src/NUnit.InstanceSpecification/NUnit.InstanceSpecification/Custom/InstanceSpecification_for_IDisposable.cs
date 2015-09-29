using System;
using NUnit.Framework;

namespace NUnit.InstanceSpecification
{
	public abstract class InstanceSpecification_for_IDisposable<TSubjectUnderTest> : InstanceSpecification<TSubjectUnderTest>
		where TSubjectUnderTest : IDisposable
	{

		[Test]
		public void It_should_MethodName()
		{
			Assert.DoesNotThrow(()=>SubjectUnderTest.Dispose());
		}

		[Test]
		public void It_should__method_to_be_called_more_than_once()
		{
			Assert.DoesNotThrow(() => SubjectUnderTest.Dispose());
			Assert.DoesNotThrow(() => SubjectUnderTest.Dispose());
		}


	}
}

