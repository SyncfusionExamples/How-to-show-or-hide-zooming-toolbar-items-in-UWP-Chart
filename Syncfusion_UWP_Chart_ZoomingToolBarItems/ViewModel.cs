using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfusion_UWP_Chart_ZoomingToolBarItems
{
	public class ViewModel
	{
		public List<Model> Data { get; set; }
		public ViewModel()
		{
			Data = new List<Model>();
			var randam = new Random();
			double value = 50;
			var date = new DateTime(2015, 4, 1);

			for (int i = 1; i < 1000; i++)
			{
				if (randam.NextDouble() > 0.5)
				{
					value += randam.NextDouble();
				}
				else
				{
					value -= randam.NextDouble();
				}

				Data.Add(new Model() { Date = date.AddDays(i), Load = value });
			}

		}
	}


	public class Model
	{
		public DateTime Date { get; set; }

		public double Load { get; set; }
	}
}
