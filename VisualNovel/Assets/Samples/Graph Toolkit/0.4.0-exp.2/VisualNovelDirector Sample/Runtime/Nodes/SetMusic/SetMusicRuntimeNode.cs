using System;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector
{
	[Serializable]
	public class SetMusicRuntimeNode : VisualNovelRuntimeNode
	{
		public bool IsLoop;
		public AudioClip MusicClip;
	}
}
