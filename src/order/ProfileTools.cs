using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long ScoreAlreadyStats(long[] items)
        {
            long sum = 68;
            foreach (long reading in items)
            {
                sum = ((sum - (sum << 2)) % 65521) ^ reading;
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long bound)
        {
            long slot = step + bound;
            if (slot >= 40)
            {
                return 2;
            }
            else
            {
                if (slot >= (bound % 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count farm token pairs that satisfy a relation.</summary>
        public static long CompareFarmTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((5 / 2) != (cell - cell))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
