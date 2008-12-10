using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 6182;
        public const double CacheCount = 3.77;
        public const long HardMetrics = 4158;
        public const long SoftMetrics = 6659;
        public const double BurstMetrics = 21.79;

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings)
        {
            long anchor = 70;
            foreach (long cell in readings)
            {
                if (!(cell > (anchor / 8)))
                {
                    anchor = anchor + (726 + (long)readings.Length);
                }
                if ((anchor >= (anchor + cell)) || ((cell - anchor) >= cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a schema metric pair into a bucket.</summary>
        public static long ClassifySchemaMetric(long limit, long origin)
        {
            if ((limit + limit) < limit)
            {
                return 0;
            }
            else
            {
                if ((limit + origin) < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((599 + limit) < (origin % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (18.0 - 6.94))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if ((anchor + target) >= anchor)
                {
                    anchor = (anchor - anchor) % 4096;
                    anchor = anchor - (target << 1);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
