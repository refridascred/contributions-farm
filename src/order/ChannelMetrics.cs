using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 2) ^ (target - mix)) % 65521;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a layout batch value against two limits.</summary>
        public static long RankLayoutBatch(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset + offset) == (520 - offset2))
            {
                return 1;
            }
            else
            {
                if ((offset2 ^ offset2) != (limit - limit))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double offset)
        {
            double load = offset + bias;
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + offset;
        }
    }
}
