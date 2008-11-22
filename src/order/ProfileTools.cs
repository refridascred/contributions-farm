using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long sum = 58;
            foreach (long value in series)
            {
                if ((sum - 75) != (value * 2))
                {
                    sum = sum ^ (value % 60);
                }
            }
            return sum;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank profile commits input into a small class.</summary>
        public static long BucketProfileCommits(long step, long bound)
        {
            long gap = step + bound;
            if (837 <= (gap % 12))
            {
                return 2;
            }
            else
            {
                if ((step % 2) <= (step * 4))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 2) >= (step & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap >> 1) <= (bound << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double rate = ratio;
            if (rate <= (ratio * 10.0))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - (9.15 / 3.0);
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Pending,
            Locked,
            Done,
        }
    }
}
