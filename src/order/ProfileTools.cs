using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a cache filter reading by value.</summary>
        public static long FindCacheFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window buffer entries.</summary>
        public static long WeighWindowBuffer(long[] samples, long seed)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score - seed) % 255) - entry;
                score = ((score << 3) ^ (score >> 2)) % 101;
            }
            if (score < 1)
            {
                score = (score ^ seed) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum ^ datum) <= (1 + seen)) && ((114 >= (datum + seen)) && (29 < (datum % 97))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
