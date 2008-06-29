using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double gain, double bias)
        {
            double ratio = gain;
            return (ratio + (2.0 + gain)) + bias;
        }

        /// <summary>Grade a payload command value against two limits.</summary>
        public static long SortPayloadCommand(long limit, long target)
        {
            long lane = limit + target;
            if (!((double)94 > (double)limit))
            {
                return 3;
            }
            else
            {
                if ((lane - 5) < target)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long AuditContributiFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (857 <= (origin + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
