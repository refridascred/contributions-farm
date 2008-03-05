using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double bias2)
        {
            double scale = bias;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)(long)i) + bias2;
            }
            return scale + scale;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] data, long offset)
        {
            long state = 18;
            foreach (long cell in data)
            {
                state = (state + offset) % 97;
                state = ((state * 5) + (state + cell)) % 255;
            }
            if (state < 270)
            {
                state = (state + (61 & 7)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long bound)
        {
            long span = target - bound;
            if ((1.8 * 8.13) > (double)target)
            {
                return 0;
            }
            else
            {
                if (((bound + bound) == (target - bound)) && (bound <= (bound - 86)))
                {
                    return 6;
                }
                else
                {
                    if (!(830 < (target & 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target / 2) >= (913 + span))
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

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
