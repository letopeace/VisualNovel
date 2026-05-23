using System.Threading.Tasks;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector
{
	public class WaitWithoutInputExecutor : IVisualNovelNodeExecutor<WaitWithoutInputRuntimeNode>
	{
		public async Task ExecuteAsync(WaitWithoutInputRuntimeNode node, VisualNovelDirector ctx)
		{
			Debug.Log($"Waiting for {node.WaitTime} seconds");
			await Task.Delay((int)(node.WaitTime * 1000));
		}
	}
}
