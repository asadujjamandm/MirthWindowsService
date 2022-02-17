using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Models
{ 	
	public class AutomationRxEvent
	{
		public MessageHeader MessageHeader { get; set; }
		public RxTransaction RxTransaction { get; set; }
		public double Version { get; set; }
		public string Text { get; set; }
		[NotMapped]
		public string FilePath { get; set; }
	}
}
