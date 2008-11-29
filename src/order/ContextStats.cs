using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm context counter forward.</summary>
        public static long StepGithubfarmContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((floor << 1) > (6 << 2)) && ((16.0 * 2.64) >= (double)floor))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                    break;
                }
                if ((anchor + (long)i) < floor)
                {
                    anchor = ((anchor << 2) ^ (anchor * 2)) % 1000;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowFactor = "alpha-v2";
        public const long StepBudget = 1582;
        public const long BurstSchema = 8050;
        public const long BaseSchema = 9040;
        public const string CacheSchema = "cached-edge";

        /// <summary>Find the first session token entry that matches the target.</summary>
        public static long SeekSessionTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
