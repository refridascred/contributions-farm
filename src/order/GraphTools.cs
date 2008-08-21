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

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double drift = bias;
            if (drift >= (rate / 4.0))
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)1) + (double)(long)i;
            }
            return drift - drift;
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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)origin < (double)4)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
