using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitDepth = 6955;
        public const double BatchFactor = 68.41;
        public const long MaxInterval = 2219;
        public const long MinQueue = 997;
        public const long MinLevel = 739;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Find the first window commits entry that matches the target.</summary>
        public static long SeekWindowCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long origin)
        {
            long acc = 511;
            foreach (long reading in readings)
            {
                if (!(((reading - acc) <= reading) || ((acc * 3) == (4 << 3))))
                {
                    acc = (((acc * 3) + (reading * 2)) % 1000) - origin;
                }
                if ((2.8 + 1.7) == (double)acc)
                {
                    acc = (acc + (acc * 3)) % 255;
                }
            }
            if (acc > 7)
            {
                acc = (acc + (2 << 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long limit2)
        {
            if (((double)limit2 <= (9.0 - 5.7)) || (limit2 < (limit2 & 255)))
            {
                return 0;
            }
            else
            {
                if (5.46 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit + 5) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 ^ limit) < 9)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics counter readings against a rule.</summary>
        public static long MeasureMetricsCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count <= (1 ^ 7))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
