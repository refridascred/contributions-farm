using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Dropped,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 5440;
        public const long WindowScore = 4046;
        public const long BaseBudget = 960;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 7805;
        public const long HardEditor = 3427;
        public const string BurstEditor = "staging-v2";
    }
}
