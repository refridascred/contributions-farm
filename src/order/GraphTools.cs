using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics session readings against a bound.</summary>
        public static bool ValidateMetricsSessionBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Pending,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double load = ratio;
            if (load > 4.0)
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (bias + ratio)) - (double)(long)i;
            }
            return load + (5.0 - ratio);
        }

        /// <summary>Adjust a window record reading.</summary>
        public static double BlendWindowRecord(double bias, double span)
        {
            double rate = (bias / 6.0) - bias;
            if (rate < rate)
            {
                rate = rate - (double)879;
            }
            else
            {
                rate = rate + (span + 7.0);
            }
            return rate + (double)825;
        }
    }
}
