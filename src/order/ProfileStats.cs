using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mark = 357;
            foreach (long reading in series)
            {
                mark = (mark << 2) ^ (reading + reading);
            }
            if (mark < 66)
            {
                mark = ((mark * 5) + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Locked,
            Active,
            Pending,
            New,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= (double)591)
            {
                scale = (scale - bias) + bias2;
            }
            return scale + (double)76;
        }
    }
}
