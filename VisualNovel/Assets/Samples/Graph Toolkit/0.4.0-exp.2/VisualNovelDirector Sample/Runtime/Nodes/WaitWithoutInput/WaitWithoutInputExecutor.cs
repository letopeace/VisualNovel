using System.Threading.Tasks;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector
{
	public class WaitWithoutInputExecutor : IVisualNovelNodeExecutor<WaitWithoutInputRuntimeNode>
	{
		public async Task ExecuteAsync(WaitWithoutInputRuntimeNode node, VisualNovelDirector ctx)
		{
			int delay = (int)(node.WaitTime * 1000);
			await Task.Delay(delay);
		}
	}
}
