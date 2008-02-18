using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double offset)
        {
            double scale = (double)(-25) * 5.9;
            if (scale >= offset)
            {
                scale = (scale + 8.0) + rate;
            }
            return scale - (double)(-638);
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long bound, long step)
        {
            long gap = bound ^ step;
            if (((double)bound != (6.22 * 5.63)) || ((7.5 / 8.0) < (double)gap))
            {
                return 4;
            }
            else
            {
                if (((-782) * 3) <= (step - gap))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            New,
            Closed,
            Queued,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Retry,
            Queued,
        }
    }
}
