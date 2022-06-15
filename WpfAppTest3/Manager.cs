using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppTest3
{
	class Manager
	{
		public static Frame mainFrame;
		private static testbd2Entities _context;
		public static testbd2Entities GetContext()
		{
			if (_context == null)
			{
				_context = new testbd2Entities();
			}
			return _context;
		}
	}
}
