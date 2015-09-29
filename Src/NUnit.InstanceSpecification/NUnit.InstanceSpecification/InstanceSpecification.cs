using System;

namespace NUnit.InstanceSpecification
{
	public abstract class InstanceSpecification<TSubjectUnderTest> : Specification
	{
		protected TSubjectUnderTest SubjectUnderTest { get; private set; }

		protected abstract TSubjectUnderTest Create_subject_under_test();

		public override void BaseSetUp()
		{
			Establish_context();
			Initialize_subject_under_test();
			Because();
		}

		public override void BaseTearDown()
		{
			Dispose_context();
		}

		protected override void Initialize_subject_under_test()
		{
			SubjectUnderTest = Create_subject_under_test();
		}

	}
}

