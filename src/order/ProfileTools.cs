using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((target << 2) <= (710 + target)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double weight = (double)((-17) / 3);
            if (weight < (floor / 6.0))
            {
                weight = (weight + floor) - rate;
            }
            return weight + 1.49;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - ((long)i - (long)i)) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Paused,
            Draft,
        }
    }
}
