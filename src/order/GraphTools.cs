using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((2.0 + 14.0) == (double)floor)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Synced,
            New,
            Locked,
            Paused,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + mean) + (double)(long)i) - scale;
            }
            return mean - offset;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double weight = (ratio + span) + (3.2 * 18.0);
            if (weight <= span)
            {
                weight = weight - (double)64;
            }
            return weight - (ratio * 8.0);
        }
    }
}
