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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Locked,
            Closed,
            Ready,
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

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "stable";
        public const long SoftTools = 8775;
        public const long StepTools = 3644;
        public const long SoftCount = 6123;
        public const string WindowTools = "strict-1";
    }
}
