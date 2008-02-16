using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((0.6 / 7.0) >= (double)entry)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (offset * 19.0))
            {
                scale = scale - (double)0;
            }
            else
            {
                scale = scale + (double)929;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset - offset)) - (double)(long)i;
            }
            return scale - (offset + ratio);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
