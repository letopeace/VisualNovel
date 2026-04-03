using System;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector.Editor
{
	[Serializable]
	internal class WaitWithoutInputNode : VisualNovelNode
	{
		public static readonly string IN_PORT_WAITTIME_NAME = "Wait Second";

		protected override void OnDefinePorts(IPortDefinitionContext context)
		{
			AddInputOutputExecutionPorts(context);

			context.AddInputPort<float>(IN_PORT_WAITTIME_NAME);
		}
	}
}
