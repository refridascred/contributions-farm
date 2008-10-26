using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long origin)
        {
            long carry = 60;
            foreach (long value in items)
            {
                carry = ((carry - origin) % 65521) ^ value;
            }
            if (carry < 5)
            {
                carry = ((carry << 2) ^ (origin ^ carry)) % 65521;
            }
            return carry % 1000;
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
