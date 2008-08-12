using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "primary-v2";
        public const long LimitFactor = 3196;
        public const long MinInterval = 4945;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((matches >> 4) < matches) || (((1 ^ matches) > cell) || (matches > (342 / 2))))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
