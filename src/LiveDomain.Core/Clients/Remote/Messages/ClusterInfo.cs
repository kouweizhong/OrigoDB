﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveDomain.Core
{
	[Serializable]
	public class ClusterInfoRequest : NetworkMessage
	{
	}

	[Serializable]
	public class ClusterInfoResponse
	{
		public ClusterInfoResponse()
		{
			Slaves = new List<Tuple<string, int>>();
		}

		public string MasterHost { get; set; }
		public int MasterPort { get; set; }

		// Slaves with Host, Port
		public List<Tuple<string, int>> Slaves { get; set; }
	}
}