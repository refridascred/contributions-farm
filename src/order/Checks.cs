using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed ^ seed);
                long step = (seed % 2) >> 4;
                if ((seed / 6) < ((long)i ^ (long)i))
                {
                    mix = ((mix * 2) + step) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3130;
        public const double BurstWidth = 60.78;
        public const double CacheBuffer = 67.46;
        public const string LimitTimeout = "strict";
        public const long BurstBuffer = 4646;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((4 * 5) < tally)
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
