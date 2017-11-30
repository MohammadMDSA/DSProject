using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSProject0.Util;

namespace DSProject0.Model
{
	class Service
	{
		public string Name { get; }
		public string CustomerDescription { get; }
		public string TechnicalDescription { get; }
		public string CarModel { get; }
		public int Expence { get; }
		private LinkedList<SubService> SubServices;

		Service(string name, string cusDesc, string techDesc, string carModel, int expence)
		{
			this.Name = name;
			this.CustomerDescription = cusDesc;
			this.TechnicalDescription = techDesc;
			this.CarModel = carModel;
			this.Expence = expence;
		}
	}

	class SubService
	{
		public string Name { get; }
		private LinkedList<SubService> SubServices;
		private LinkedList<Service> ParrentServices;
	}
}
