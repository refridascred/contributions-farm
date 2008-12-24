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

        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long CountRouteTokenMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits <= (item - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
