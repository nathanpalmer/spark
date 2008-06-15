﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Spark.FileSystem;

namespace Spark.Tests.Stubs
{
	public class StubViewFactory
	{
		public ISparkViewEngine Engine { get; set;}

		public void RenderView(StubViewContext viewContext)
		{
			var sparkView = Engine.CreateInstance(viewContext.ControllerName, viewContext.ViewName, viewContext.MasterName);			
            sparkView.RenderView(new StringWriter(viewContext.Output));			
		}
	}
}