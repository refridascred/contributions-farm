using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TallyMetricWindow(long[] samples)
        {
            long total = 913;
            foreach (long sample in samples)
            {
                if (!((5.34 / 7.0) <= (double)sample))
                {
                    total = total - (sample % 7);
                }
                total = (total ^ (total >> 5)) % 1000;
            }
            if (total > 36)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double bias, double offset)
        {
            double weight = (offset - bias) - (double)505;
            return weight + (weight - weight);
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long bound2)
        {
            if ((double)bound2 <= (1.6 / 3.0))
            {
                return 1;
            }
            else
            {
                if (((bound2 >> 3) <= (bound2 << 1)) && (bound <= (bound << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 - bound2) > (bound * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound != (4.5 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long origin)
        {
            long sum = 58;
            foreach (long cell in data)
            {
                if ((5.18 / 2.0) <= (double)origin)
                {
                    sum = ((sum + sum) % 65521) ^ cell;
                }
            }
            return sum % 97;
        }
    }
}
