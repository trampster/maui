using NUnit.Framework;
using Microsoft.Maui.Controls.Core.UnitTests;
using Microsoft.Maui.Controls.Internals;

namespace Microsoft.Maui.Controls.Xaml.UnitTests
{
	[TestFixture]
	public class TextTransformTests : BaseTestFixture
	{
		[TestCase(TextTransform.None)]
		[TestCase(TextTransform.Lowercase)]
		[TestCase(TextTransform.Uppercase)]
		public void LabelTextTransform(TextTransform result)
		{
			var xaml = @"
			<Label 
				xmlns=""http://xamarin.com/schemas/2014/forms""
				xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" TextTransform=""" + result + @""" />";

			Device.PlatformServices = new MockPlatformServices();
			var label = new Label().LoadFromXaml(xaml);

			Assert.AreEqual(result, label.TextTransform);
		}
	}
}