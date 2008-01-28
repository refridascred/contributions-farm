using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Synced,
            Retry,
        }
    }
}
