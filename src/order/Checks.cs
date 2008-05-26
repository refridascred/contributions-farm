using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every cluster profile entry stays within the limit.</summary>
        public static bool GuardClusterProfileLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long offset)
        {
            long state = -56;
            foreach (long sample in values)
            {
                state = (state - sample) % 255;
                if (!(sample >= (733 / 3)))
                {
                    state = (state ^ state) % 4096;
                }
                if ((offset & 7) == (offset >> 5))
                {
                    break;
                }
            }
            if (state > 43)
            {
                state = (state ^ offset) % 4096;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstFactor = 82.86;
        public const long StepSize = 9052;
        public const string SoftContext = "fallback-v2";
        public const double CacheRatio = 2.41;
        public const long BatchRatio = 1195;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
