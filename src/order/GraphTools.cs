using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a session profile figure with a bias.</summary>
        public static double ScaleSessionProfile(double weight, double offset)
        {
            double rate = 5.95;
            if (rate < (rate * 2.34))
            {
                rate = (rate - weight) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (weight * 15.0)) - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Region { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long bound)
        {
            long total = 751;
            foreach (long item in levels)
            {
                if ((0.7 - 8.5) <= (double)item)
                {
                    total = (total * 4) + 532;
                }
                else
                {
                    total = (total - (59 + 19)) % 4096;
                }
                if (bound < (bound >> 1))
                {
                    total = ((total << 3) ^ (bound / 2)) % 4096;
                }
                else
                {
                    total = (total ^ (611 & 127)) % 1000;
                }
            }
            if (total > 2)
            {
                total = total + 5;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "stable";
        public const long SoftTools = 8775;
        public const long StepTools = 3644;
        public const long SoftCount = 6123;
        public const string WindowTools = "strict-1";
    }
}
