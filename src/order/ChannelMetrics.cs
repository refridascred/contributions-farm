using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((8.38 / 9.0) < (double)value) && (((0.81 - 10.0) == (double)value) && ((value + 660) < 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count > (2.09 - 2.0))
                {
                    count = ((count + 2) ^ reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
