using System;
using UnityEngine;

namespace Unity.GraphToolkit.Samples.VisualNovelDirector.Editor
{
    /// <summary>
    /// Represents the Set Dialogue Node in the Visual Novel Director tool.
    /// </summary>
    /// <remarks>
    /// Is converted to a <see cref="SetDialogueRuntimeNode"/> for the runtime.
    /// </remarks>
    [Serializable]
    internal class SetDialogueNode : VisualNovelNode
    {
        public const string IN_PORT_ACTOR_NAME_NAME = "ActorName";

        public const string IN_PORT_FULLBACK_SPRITE_NAME = "FullBackSprite";
		public const string IN_PORT_FULL_SPRITE_NAME = "FullSprite";
		public const string IN_PORT_LEFT_SPRITE_NAME = "LeftSprite";
		public const string IN_PORT_RIGHT_SPRITE_NAME = "RightSprite";
		public const string IN_PORT_FULLFRONT_SPRITE_NAME = "FullFrontSprite";

		public const string IN_PORT_DIALOGUE_NAME = "Dialogue";

        public enum Location
        {
            FullBack = 0,
            Full = 1,
            Left = 2,
            Right = 3,
            FullFront = 4
        }

        /// <summary>
        /// Defines the output for the node.
        /// </summary>
        /// <param name="context">The scope to define the node.</param>
        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            AddInputOutputExecutionPorts(context);

            context.AddInputPort<string>(IN_PORT_ACTOR_NAME_NAME)
                .WithDisplayName("Actor Name")
                .Build();

            context.AddInputPort<Sprite>(IN_PORT_FULLBACK_SPRITE_NAME)
                .WithDisplayName("Full Back")
                .Build();
			context.AddInputPort<Sprite>(IN_PORT_FULL_SPRITE_NAME)
				.WithDisplayName("Full")
				.Build();
			context.AddInputPort<Sprite>(IN_PORT_LEFT_SPRITE_NAME)
				.WithDisplayName("Left")
				.Build();
			context.AddInputPort<Sprite>(IN_PORT_RIGHT_SPRITE_NAME)
				.WithDisplayName("Right")
				.Build();
			context.AddInputPort<Sprite>(IN_PORT_FULLFRONT_SPRITE_NAME)
				.WithDisplayName("Full Front")
				.Build();

			context.AddInputPort<string>(IN_PORT_DIALOGUE_NAME)
                .Build();

        }
    }
}
