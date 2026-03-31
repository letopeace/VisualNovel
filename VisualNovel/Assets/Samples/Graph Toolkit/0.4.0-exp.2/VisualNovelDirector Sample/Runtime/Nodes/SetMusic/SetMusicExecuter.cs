using System.Threading.Tasks;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector
{
	public class SetMusicExecuter : IVisualNovelNodeExecutor<SetMusicRuntimeNode>
	{
		public async Task ExecuteAsync(SetMusicRuntimeNode runtimeNode, VisualNovelDirector ctx)
		{
			if (runtimeNode.IsLoop)
			{
				ctx.MusicPlayer.clip = runtimeNode.MusicClip;
				ctx.MusicPlayer.Play();
				await Task.Yield();
			}
			else
			{
				ctx.SaundEffectPlayer.clip = runtimeNode.MusicClip;
				ctx.SaundEffectPlayer.Play();
				await Task.Yield();
			}
		}
	}
}
