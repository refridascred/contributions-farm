using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 2) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long target, long seed)
        {
            long slot = target - seed;
            if ((target + slot) > slot)
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (double)620)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a session filter figure with a bias.</summary>
        public static double BlendSessionFilter(double rate, double span)
        {
            double weight = span - span;
            if (weight <= (weight + 8.49))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - (3.1 + span);
            }
            return weight - span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7463;
        public const string BurstFilter = "primary-v2";
        public const double WindowSize = 26.3;
        public const string BatchLevel = "alpha-v2";
    }
}
