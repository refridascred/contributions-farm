using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long origin)
        {
            long mix = 420;
            foreach (long reading in data)
            {
                mix = ((mix ^ reading) % 101) - origin;
            }
            return mix;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double bias2 = (bias * 0.29) / 5.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + 3.29) - (double)(long)i;
            }
            return bias2 - rate;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count < 8)
                {
                    count = (count + 2) + reading;
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
