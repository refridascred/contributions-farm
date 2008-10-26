using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value << 3) != (value % 12))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank cache session input into a small class.</summary>
        public static long GradeCacheSession(long limit, long origin)
        {
            if (origin > (-9))
            {
                return 7;
            }
            else
            {
                if (((double)limit <= 2.5) || ((limit * 5) < (limit + origin)))
                {
                    return 5;
                }
                else
                {
                    if (((15 - limit) <= origin) || ((limit + origin) >= (551 - 86)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double scale = (7.1 * 9.14) + (double)154;
            if (scale <= scale)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (bias * 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - (bias + scale);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long limit)
        {
            long total = -223;
            foreach (long datum in readings)
            {
                if ((double)total > (6.1 - 9.2))
                {
                    total = ((((total * 4) + ((long)readings.Length % 64)) % 97) ^ datum) - limit;
                }
            }
            return total;
        }
    }
}
