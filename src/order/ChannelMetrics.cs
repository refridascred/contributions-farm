using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long offset)
        {
            long mix = 913;
            foreach (long reading in readings)
            {
                if ((reading + mix) > offset)
                {
                    mix = mix ^ 6;
                }
                else
                {
                    mix = mix - (68 / 7);
                }
            }
            return mix % 97;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 + (double)218) + rate;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((9.19 * 14.0) > (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
