using System;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector
{
    /// <summary>
    /// The serializable data representing a runtime node in the visual novel graph that sets the dialogue text and actor information.
    /// </summary>
    [Serializable]
    public class SetDialogueRuntimeNode : VisualNovelRuntimeNode
    {
        public string ActorName;
        public Sprite FullBackSprite;
		public Sprite FullSprite;
		public Sprite LeftSprite;
		public Sprite RightSprite;
		public Sprite FullFrontSprite;
		public string DialogueText;
    }
}
