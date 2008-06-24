using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a channel layout figure with a bias.</summary>
        public static double ProjectChannelLayout(double weight, double span)
        {
            double scale = span;
            return (scale + 0.05) + weight;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + count) <= (3 & 255))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if ((offset + offset) > offset)
            {
                return 0;
            }
            else
            {
                if ((origin <= offset) || (origin < (origin - 41)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Paused,
            New,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Count { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
