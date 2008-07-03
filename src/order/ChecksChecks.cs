using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCount = 3204;
        public const long LimitCache = 1048;
        public const long LimitScore = 9723;
        public const long BaseSize = 8288;
        public const string BatchSpan = "standard";
    }
}
