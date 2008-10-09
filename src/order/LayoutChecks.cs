using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if (entry > (entry + entry))
                {
                    total = (total ^ (entry + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long offset)
        {
            long offset2 = step + offset;
            if ((double)offset < 18.0)
            {
                return 5;
            }
            else
            {
                if ((step + offset2) < (offset % 3))
                {
                    return 8;
                }
                else
                {
                    if (((offset ^ offset2) > offset2) || ((double)offset2 > (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - offset) > (offset ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double scale = (bias * 8.8) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - rate;
            }
            return scale + scale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] data, long seed)
        {
            long anchor = 769;
            foreach (long value in data)
            {
                if ((anchor / 2) >= value)
                {
                    anchor = ((anchor * 2) + (6 + value)) + seed;
                }
            }
            return anchor;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}
