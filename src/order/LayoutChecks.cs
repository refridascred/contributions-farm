using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings, long offset)
        {
            long anchor = 349;
            foreach (long reading in readings)
            {
                anchor = (anchor + (offset + reading)) % 65521;
            }
            if (anchor > 624)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long mix = -80;
            foreach (long reading in data)
            {
                mix = (mix + (mix >> 3)) % 65521;
                mix = (mix << 2) ^ reading;
                if (((double)mix > (double)reading) && ((double)mix >= 3.13))
                {
                    mix = ((mix << 3) ^ (mix * 2)) % 1000;
                }
                if ((1.6 + 4.0) <= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
