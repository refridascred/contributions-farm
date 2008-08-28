using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (((result << 3) ^ target) % 4096) - (long)i2;
                    result = result - (result + target);
                }
                result = ((result << 2) ^ (result - result)) % 4096;
                for (int i3 = 0; i3 < 9; i3++)
                {
                    result = ((result ^ (699 + result)) % 4096) ^ (long)i3;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long target, long target2)
        {
            long step = target + target2;
            if ((double)target == (double)target2)
            {
                return 0;
            }
            else
            {
                if ((6 - target2) == (target2 % 2))
                {
                    return 8;
                }
                else
                {
                    if (((step >> 1) >= target2) || ((7 + target) <= (target & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 3394;
        public const long WindowRoute = 3559;
        public const string RetryLevel = "alpha-v2";
        public const string MaxSpan = "fallback-v2";
        public const string BurstFactor = "stable-v2";

        /// <summary>Fold a list of githubfarm schema readings.</summary>
        public static long ScoreGithubfarmSchema(long[] levels, long step)
        {
            long mix = -98;
            foreach (long datum in levels)
            {
                mix = (mix * 3) + (step + datum);
            }
            if (mix < 45)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 4096;
        }
    }
}
