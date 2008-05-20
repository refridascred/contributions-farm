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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + item) >= (seen >> 2))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
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

        /// <summary>Compare every pair of batch channel readings.</summary>
        public static long PairBatchChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
