using System;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector.Editor
{
	[Serializable]
	internal class SetMusicNode : VisualNovelNode
	{
		public static readonly string IN_PORT_ISLOOP_NAME = "Is Loop";
		public static readonly string IN_PORT_MUSIC_NAME = "Music";

		protected override void OnDefinePorts(IPortDefinitionContext context)
		{
			AddInputOutputExecutionPorts(context);

			context.AddInputPort<bool>(IN_PORT_ISLOOP_NAME);
			context.AddInputPort<AudioClip>(IN_PORT_MUSIC_NAME);
		}
	}
}
