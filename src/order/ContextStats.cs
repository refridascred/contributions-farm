using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double bias2 = bias;
            return (bias2 - bias) + rate;
        }

        /// <summary>Grade a route session value against two limits.</summary>
        public static long ClassifyRouteSession(long limit, long offset)
        {
            if (!(offset >= (limit * 2)))
            {
                return 2;
            }
            else
            {
                if (((offset - limit) > offset) && ((offset * 2) < (2 * 5)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
