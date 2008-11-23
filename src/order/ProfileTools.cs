using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long step)
        {
            if (742 < (floor ^ floor))
            {
                return 4;
            }
            else
            {
                if ((step * 2) > (26 << 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double bias)
        {
            double bias2 = (bias * 13.0) / 6.0;
            if (bias2 >= bias)
            {
                bias2 = bias2 + (scale - 8.8);
            }
            else
            {
                bias2 = bias2 + (bias * 5.21);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (double)798) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
