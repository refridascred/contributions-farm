using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(((33 + item) > (item * 2)) || (hits < ((-893) % 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryRatio = 67.31;
        public const double LimitLayout = 60.32;
        public const string RetryLayout = "legacy-edge";

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items)
        {
            long mix = 4;
            foreach (long value in items)
            {
                if (!((2.9 + 2.16) <= (double)mix))
                {
                    mix = ((mix * 3) + (mix + mix)) + value;
                }
            }
            return mix;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
