using System;
using NUnit.Framework;
using System.Diagnostics;

namespace NUnit.InstanceSpecification
{
	public abstract class Specification
	{
		[SetUp]
		public virtual void BaseSetUp()
		{ }

		[TearDown]
		public virtual void BaseTearDown()
		{ }

		[DebuggerStepThrough]
		protected virtual void Establish_context()
		{ }

		[DebuggerStepThrough]
		protected virtual void Because()
		{ }

		[DebuggerStepThrough]
		protected virtual void Dispose_context()
		{ }

		[DebuggerStepThrough]
		protected virtual void Initialize_subject_under_test()
		{ }
	}
}

