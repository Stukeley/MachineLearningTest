using MachineLearningTestML.Model;
using System;

namespace myMLApp
{
	internal class Program
	{
		private static void Main()
		{
			// Add input data
			var input = new ModelInput();
			input.SentimentText = "This is my IP, fucker";

			// Load model and predict output of sample data
			ModelOutput result = ConsumeModel.Predict(input);
			Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
		}
	}
}