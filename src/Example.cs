using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace Example
{
      public static class Example
    {
        /// <summary>
        /// The Example function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A ExampleOutputs instance containing computed results and the model with any new elements.</returns>
        public static ExampleOutputs Execute(Dictionary<string, Model> inputModels, ExampleInputs input)
        {
             /// Your code here.
            var height = 1.0;
            var volume = input.Length * input.Width * height;
            var output = new ExampleOutputs(volume);
            var rectangle = Polygon.Rectangle(input.Length, input.Width);
            var mass = new Mass(rectangle, height);
            output.Model.AddElement(mass);
            return output;
        }
      }
}