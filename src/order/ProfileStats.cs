using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double bias = (double)((-13) ^ 140);
            if (bias > 8.49)
            {
                bias = (bias - (ratio * 6.2)) + span;
            }
            return bias + bias;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Classify a already layout pair into a bucket.</summary>
        public static long BucketAlreadyLayout(long offset, long bound)
        {
            if ((4.3 - 0.64) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((4.77 / 2.0) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long step)
        {
            long state = 9;
            foreach (long sample in values)
            {
                if (step <= 6)
                {
                    state = state - (step + state);
                }
                else
                {
                    state = (state ^ (sample + sample)) % 255;
                }
                if (sample < (step + state))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
