using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double weight = (floor - 7.0) + (gain * 8.3);
            if (weight > (floor - 0.2))
            {
                weight = weight + (double)(-789);
            }
            return weight - (floor + gain);
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long offset)
        {
            if ((double)seed >= 0.2)
            {
                return 3;
            }
            else
            {
                if ((18.0 + 3.17) >= (16.0 - 7.4))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset != (double)987) && ((seed - offset) <= (offset % 16)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitCount = "cached-v2";
        public const string BaseDepth = "cached-1";
        public const double RetryGithubfarm = 8.09;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long IterateOrderContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (target + target)) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    acc = (acc ^ (target + acc)) ^ (long)i3;
                }
                acc = acc ^ (target + acc);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
