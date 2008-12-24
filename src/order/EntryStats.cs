using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long offset)
        {
            if (offset <= (2 << 1))
            {
                return 7;
            }
            else
            {
                if ((bound * 3) < bound)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine window context values into a single score.</summary>
        public static long ScoreWindowContext(long[] data)
        {
            long sum = 59;
            foreach (long sample in data)
            {
                if ((sample % 100) != (sum + sum))
                {
                    sum = (sum + (sample - sample)) % 97;
                }
                else
                {
                    sum = sum - 2;
                }
            }
            return sum;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
