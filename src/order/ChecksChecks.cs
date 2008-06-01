using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 469;
        public const long SoftGithubfarm = 8853;
        public const long MaxSpan = 3011;

        /// <summary>Fold a list of cache token readings.</summary>
        public static long CombineCacheToken(long[] readings)
        {
            long mix = 87;
            foreach (long datum in readings)
            {
                if ((88 ^ datum) != (8 + mix))
                {
                    mix = ((mix << 3) ^ (mix + datum)) % 65521;
                }
                else
                {
                    mix = mix + (15 + 7);
                }
            }
            return mix % 4096;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
