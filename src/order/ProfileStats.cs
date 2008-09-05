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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 3) ^ (sum / 2)) % 97;
                if ((sum >> 4) > (long)i)
                {
                    sum = (sum ^ (sum / 4)) % 97;
                }
                if (!(sum >= (9 * 2)))
                {
                    sum = (sum + (sum / 7)) % 97;
                    sum = (sum * 3) + (sum >> 5);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
