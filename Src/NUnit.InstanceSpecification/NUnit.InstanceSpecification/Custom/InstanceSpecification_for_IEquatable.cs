using System;
using NUnit.Framework;

namespace NUnit.InstanceSpecification
{
	public abstract class InstanceSpecification_for_IEquatable<TSubjectUnderTest, TItem> : InstanceSpecification<TSubjectUnderTest>
		where TSubjectUnderTest : IEquatable<TItem>
	{


		public abstract TItem Get_Subject_to_compare_to_be_equalas();
		public abstract TItem Get_Subject_to_compare_to_be_diffrent();



		[Test]
		public virtual void It_should_return_true_because_same_reference()
		{
			Assert.IsTrue(SubjectUnderTest.Equals(SubjectUnderTest));
		}


		#region relation
		//relacja zwrotna  

		[Test]
		public virtual void It_should_be_reflexive_relation()
		{
			TSubjectUnderTest sut2 = Create_subject_under_test();
			Assert.IsTrue(SubjectUnderTest.Equals(sut2));
		}

		//relacja symetryczna  
		[Test]
		public virtual void It_should_be_symmetric_relation()
		{
			TItem itemToComapre = Get_Subject_to_compare_to_be_equalas();

			bool number1To2 = SubjectUnderTest.Equals(itemToComapre);
			bool number2To1 = itemToComapre.Equals(SubjectUnderTest);
			Assert.AreEqual(number1To2, number2To1);
		}

		//relacja przechodnia  
		[Test]
		public virtual void It_should_be_transitive_relation()
		{
			TItem number1 = Get_Subject_to_compare_to_be_equalas();
			TItem number2 = Get_Subject_to_compare_to_be_equalas();


			Assert.IsTrue(SubjectUnderTest.Equals(number1));
			Assert.IsTrue(number1.Equals(number2));
			Assert.IsTrue(number2.Equals(SubjectUnderTest));
		}
		#endregion


		protected int NumberOfRepeatedTestRuns = 10;

		[Test]
		public virtual void It_should_return_always_the_same_value_for_Equals()
		{
			var bools = new List<bool>();
			for (int i = 0; i < NumberOfRepeatedTestRuns; i++)
			{
				TItem sutToCompare = Get_Subject_to_compare_to_be_equalas();

				bools.Add(SubjectUnderTest.Equals(sutToCompare));
			}
			Assert.IsTrue(bools.All(x => x));
		}


		#region Diff object
		[Test]
		public void It_should_retunn_fale_bacause_comaptre_object_is_diffrent()
		{
			TItem diff = Get_Subject_to_compare_to_be_diffrent();
			Assert.IsFalse(SubjectUnderTest.Equals(diff));
		}


		[Test]
		public void It_should_return_false_bacuase_comapring_object_are_diffrent()
		{
			TItem same = Get_Subject_to_compare_to_be_equalas();
			TItem diff = Get_Subject_to_compare_to_be_diffrent();
			Assert.IsFalse(diff.Equals(same));
		}
		#endregion


		#region Default values
		private bool SubjectIsValueType()
		{
			return typeof(TSubjectUnderTest).IsValueType;
		}

		private bool SubjectToComapreIsValueType()
		{
			return typeof(TItem).IsValueType;
		}  

		[Test]
		public virtual void It_should_return_always_true_for_default_values_in_valueType()
		{
			if (SubjectIsValueType() && SubjectToComapreIsValueType())
			{
				for (int i = 0; i < NumberOfRepeatedTestRuns; i++)
				{
					var value1 = default(TSubjectUnderTest);
					var value2 = default(TItem);
					Assert.IsTrue(value1.Equals(value2));
				}
			}
		}

		[Test]
		public virtual void It_should_return_false_because_comparing_to_null()
		{
			if (!SubjectIsValueType())
			{
				Assert.IsFalse(SubjectUnderTest.Equals(null));
			}
		}

		[Test]
		public virtual void It_should_return_false_because_comparing_to_default_value_null()
		{
			if (!SubjectIsValueType())
			{
				var value1 = default(TItem);
				Assert.IsFalse(SubjectUnderTest.Equals(value1));
			}
		}  
		#endregion 
	}
}

