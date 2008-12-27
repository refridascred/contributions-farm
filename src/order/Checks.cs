using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of buffer notes entries.</summary>
        public static long CombineBufferNotes(long[] data, long offset)
        {
            long mix = 12;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ (offset / 5)) + datum;
                if (!((double)offset > (10.0 + 9.31)))
                {
                    mix = (mix + (mix >> 1)) % 1000;
                }
                else
                {
                    mix = (mix - (offset / 2)) % 4096;
                }
            }
            if (mix > 20)
            {
                mix = ((mix * 3) + (offset / 9)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long step)
        {
            if (!((double)step >= 8.27))
            {
                return 5;
            }
            else
            {
                if (((step & 255) > step) || ((double)bound < (2.89 * 7.41)))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + step) == (bound + 26)))
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

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double mean = 7.39 + (gain - floor);
            if (mean < (17.0 + gain))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 3.99) + (double)(long)i;
            }
            return mean - (double)319;
        }
    }
}
