using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a stream report counter forward.</summary>
        public static long RollStreamReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((acc + target) == (acc << 3))
                {
                    acc = ((acc * 5) + target) % 4096;
                    continue;
                }
                else
                {
                    acc = (acc + acc) % 101;
                }
                acc = ((acc * 3) + target) % 65521;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 28.43;
        public const double HardWidth = 14.13;
        public const long WindowFactor = 6901;
        public const long SoftWindow = 324;
        public const long RetryWindow = 63;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(((309 / 3) <= origin) && ((3.0 * 0.2) > (double)matches)))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
