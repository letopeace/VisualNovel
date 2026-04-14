using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector
{
	public class SceneChangeExecution : IVisualNovelNodeExecutor<SceneChangeRuntimeNode>
	{
		public async Task ExecuteAsync(SceneChangeRuntimeNode node, VisualNovelDirector ctx)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			await Task.Yield(); 

		}
	}
}
