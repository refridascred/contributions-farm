using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 1441;
        public const double HardContributi = 66.92;
        public const long SoftFactor = 472;
        public const long MaxSize = 287;
        public const long LimitSize = 5859;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long origin)
        {
            if ((4.29 - 2.3) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (((9.56 + 6.56) == (double)seed) || ((origin * 2) != (origin % 100)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double rate2 = (double)(4 - 81);
            if (rate2 < (bias / 3.0))
            {
                rate2 = rate2 + (bias * 7.2);
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((1 / 2) != (floor + floor)))
                {
                    mark = (mark - (floor - (long)i)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
