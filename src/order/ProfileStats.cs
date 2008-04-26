using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen > (6.0 / 6.0))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double offset)
        {
            double gain = bias;
            if (gain > (9.54 * 6.26))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 2.5) + (double)(long)i;
            }
            return gain + (gain / 4.0);
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Queued,
            Failed,
            Draft,
            Idle,
        }
    }
}
