using System;
using NUnit.Framework;

namespace NUnit.InstanceSpecification
{
	[TestFixture("pl-PL")]
	[TestFixture("de-DE")]
	[TestFixture("en-US")]
	[TestFixture("en-GB")]
	[TestFixture("ko-KR")]
	[TestFixture("tr-TR")]
	public abstract class InstanceSpecification_with_Culture<TSubjectUnderTest> : InstanceSpecification<TSubjectUnderTest>
	{
		public InstanceSpecification_with_Culture(string culture)
		{
			CultureInfo ci = new CultureInfo(culture);
			Thread.CurrentThread.CurrentUICulture = ci;
			Thread.CurrentThread.CurrentCulture = ci;
		}
	}
}

