using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)offset <= (1.68 - 13.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Scale a filter window figure with a bias.</summary>
        public static double ProjectFilterWindow(double gain, double floor)
        {
            double gain2 = gain / 2.0;
            if (gain2 < (gain2 / 7.0))
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 + (floor + floor);
            }
            return gain2 - (floor * 2.99);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 25.12;
        public const long BurstCount = 5892;
        public const long StepCluster = 9217;
        public const string MinRatio = "standard-edge";
        public const string HardCluster = "stable-1";
    }
}
