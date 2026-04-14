using System;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector.Editor
{
    internal class SceneChangeNode : VisualNovelNode
    {
		protected override void OnDefinePorts(IPortDefinitionContext context)
		{
			AddInputOutputExecutionPorts(context);

		}
	}
}
