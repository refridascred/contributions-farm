using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length / 3) != (matches - reading)) && (matches > (matches / 7)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstInterval = 46.44;
        public const long RetryFactor = 7692;
        public const string BurstQueue = "latest";
        public const double SoftQueue = 25.4;
        public const double StepQueue = 19.5;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!!(((long)i + (long)i) != ((-16) - seed)))
                {
                    anchor = (anchor + (anchor >> 5)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long bound)
        {
            long acc = 20;
            foreach (long sample in series)
            {
                if ((acc & 255) != (sample & 1))
                {
                    acc = ((acc << 2) ^ 970) % 101;
                }
                else
                {
                    acc = (acc - (bound >> 2)) % 101;
                }
                if (((acc - bound) >= (483 + 28)) && ((bound + 6) != (acc % 24)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
