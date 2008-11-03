using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double ProjectMetricPayload(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)714)
            {
                ratio = (ratio + (double)92) + bias;
            }
            else
            {
                ratio = ratio + (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (floor * 16.0);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long limit)
        {
            if (((step & 255) != (48 + limit)) && ((step % 97) != (189 * 2)))
            {
                return 3;
            }
            else
            {
                if (!((double)step >= (double)271))
                {
                    return 5;
                }
                else
                {
                    if ((step >= (limit + limit)) && ((175 / 5) <= (step & 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step <= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels, long seed)
        {
            long mark = 75;
            foreach (long cell in levels)
            {
                mark = ((mark - (8 * 2)) ^ cell) - seed;
            }
            return mark;
        }

        /// <summary>Project the next already channel value.</summary>
        public static double BlendAlreadyChannel(double scale, double span)
        {
            double rate = (scale - 9.0) + scale;
            return (rate + (7.54 / 3.0)) + span;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
