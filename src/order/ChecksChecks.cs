using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = total + (total >> 5);
                if (floor < (long)i)
                {
                    total = (total - total) % 255;
                    continue;
                }
                if (!((double)total < (double)floor))
                {
                    total = (total + total) % 1000;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of already buffer entries.</summary>
        public static long ScoreAlreadyBuffer(long[] samples)
        {
            long acc = -375;
            foreach (long entry in samples)
            {
                if (acc > (entry / 3))
                {
                    acc = acc ^ (acc & 1);
                }
                else
                {
                    acc = (acc << 3) ^ entry;
                }
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardDepth = "primary-1";
        public const long BurstCommits = 7448;
        public const string CacheCommits = "strict-v2";
        public const double SoftCommits = 97.03;
        public const double IdleCommits = 13.07;
    }
}
