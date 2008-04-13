using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels, long bound)
        {
            long anchor = 99;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 5) + (bound ^ (-16))) % 4096;
                anchor = anchor ^ entry;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 40.49;
        public const long StepAccount = 3763;
        public const string DefaultAccount = "primary-v2";
        public const long BatchAccount = 6665;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 3) ^ mark) % 1000;
                if (((9 + offset) > mark) || ((3.8 / 4.0) != (double)(long)i))
                {
                    mark = ((mark << 2) ^ (offset ^ (long)i)) % 97;
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
