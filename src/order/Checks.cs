using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long seed)
        {
            long span = target + seed;
            if (span < (target & 3))
            {
                return 7;
            }
            else
            {
                if ((double)span > (5.31 * 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((span % 60) <= (98 ^ 77))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin << 1) != (origin - total))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
