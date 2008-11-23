using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples, long step)
        {
            long total = 62;
            foreach (long datum in samples)
            {
                if ((304 ^ 888) <= total)
                {
                    total = (total - ((-134) + 988)) % 101;
                }
                if ((total & 1) <= datum)
                {
                    break;
                }
            }
            if (total > 388)
            {
                total = (total + step) % 65521;
            }
            return total;
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
