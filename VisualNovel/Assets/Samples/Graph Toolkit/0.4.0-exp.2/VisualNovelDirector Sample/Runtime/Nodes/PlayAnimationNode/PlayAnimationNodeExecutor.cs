using System.Threading.Tasks;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector
{
	public class PlayAnimationNodeExecutor : IVisualNovelNodeExecutor<PlayAnimationRuntimeNode>
	{
		public async Task ExecuteAsync(PlayAnimationRuntimeNode node, VisualNovelDirector ctx)
		{
			ctx.tryaskaAnim.Play();
			await Task.Yield();
		}
	}
}
