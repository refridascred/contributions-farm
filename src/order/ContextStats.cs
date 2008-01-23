using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double bias)
        {
            double scale2 = scale / 9.0;
            if (scale2 <= scale)
            {
                scale2 = (scale2 + (20.0 * 3.9)) - bias;
            }
            else
            {
                scale2 = scale2 + (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (scale + 8.0)) + (double)(long)i;
            }
            return scale2 - (double)57;
        }
    }
}
