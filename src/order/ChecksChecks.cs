using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
