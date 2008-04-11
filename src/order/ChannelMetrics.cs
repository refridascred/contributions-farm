using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long acc = -83;
            foreach (long reading in series)
            {
                if (0.6 < (double)acc)
                {
                    acc = ((acc * 5) + (reading * 2)) % 255;
                }
                if (!((acc - acc) == (594 % 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long limit, long bound)
        {
            long prev = limit + bound;
            if ((limit << 1) == (limit - prev))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) > (limit >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((prev & 255) >= (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length >= (seen - value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
