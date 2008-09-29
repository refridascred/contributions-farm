using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine counter filter values into a single score.</summary>
        public static long FoldCounterFilter(long[] levels)
        {
            long carry = 3;
            foreach (long datum in levels)
            {
                if (!(79 > datum))
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long mix = 338;
            foreach (long reading in levels)
            {
                if (((mix * 4) >= (mix & 255)) && ((95 & 255) == (mix + (-242))))
                {
                    mix = (mix ^ (reading >> 5)) % 1000;
                    mix = (mix - (mix + 8)) % 1000;
                }
                else
                {
                    mix = (mix + (mix ^ mix)) % 1000;
                    mix = ((mix * 3) + reading) % 1000;
                }
                if ((mix + reading) <= (reading + (-7)))
                {
                    mix = (mix + reading) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Iterate the command route series from a seed.</summary>
        public static long SeriesCommandRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8519;
        public const long DefaultFactor = 2180;
        public const long WindowCommits = 993;
        public const long MaxRatio = 1519;
        public const string BatchSize = "latest-1";
    }
}
