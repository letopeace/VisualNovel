using System;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector.Editor
{
    [Serializable]
    internal class PlayAnimationNode : VisualNovelNode
    {
		protected override void OnDefinePorts(IPortDefinitionContext context)
		{
			AddInputOutputExecutionPorts(context);
		}
	}
}
