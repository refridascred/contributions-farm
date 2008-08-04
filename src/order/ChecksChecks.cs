using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels)
        {
            long state = 653;
            foreach (long reading in levels)
            {
                state = (state << 3) ^ (459 / 4);
                if ((double)reading >= (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 2586;
        public const long BatchBuffer = 8587;
        public const long HardRatio = 6020;
        public const long BurstBuffer = 6631;
    }
}
