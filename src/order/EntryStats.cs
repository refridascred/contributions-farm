using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long origin, long step)
        {
            if ((8.1 * 8.77) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin < (6.39 + 8.15))
                {
                    return 7;
                }
                else
                {
                    if ((step / 5) > (origin / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9463;
        public const long MinMetrics = 338;
        public const string SoftWidth = "strict";

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double rate = (double)(7 >> 4);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - rate) + (double)(long)i) + floor;
            }
            return rate + ratio;
        }

        /// <summary>Validate batches record readings against a bound.</summary>
        public static bool GuardBatchesRecordRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
