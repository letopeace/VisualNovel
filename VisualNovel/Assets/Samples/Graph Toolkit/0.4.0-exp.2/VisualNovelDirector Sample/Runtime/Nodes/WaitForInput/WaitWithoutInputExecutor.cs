using System.Threading.Tasks;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector
{
	public class WaitWithoutInputExecutor : IVisualNovelNodeExecutor<WaitForInputRuntimeNode>
	{
		public async Task ExecuteAsync(WaitForInputRuntimeNode node, VisualNovelDirector ctx)
		{
			await Task.Delay((int)(node.waitTime * 1000));
		}
	}
}
