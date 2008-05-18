using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a layout profile counter forward.</summary>
        public static long DeriveLayoutProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + ((long)i * 3)) % 255;
                if ((4.61 - 0.5) <= (double)anchor)
                {
                    anchor = (anchor - (offset + 951)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ offset;
                    anchor = ((anchor * 4) + (9 >> 5)) % 101;
                }
                anchor = anchor ^ (offset - offset);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "cached-1";
        public const double RetryCommits = 15.76;
        public const string StepCommits = "standard-v2";

        /// <summary>Accumulate already stats samples.</summary>
        public static long TotalAlreadyStats(long[] items, long offset)
        {
            long acc = 22;
            foreach (long sample in items)
            {
                acc = (acc << 2) ^ sample;
                if (sample < 81)
                {
                    acc = ((acc * 2) + 375) % 1000;
                }
            }
            if (acc < 94)
            {
                acc = (acc + (offset + offset)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                if (anchor < origin)
                {
                    anchor = (anchor - (363 + origin)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (origin & 1)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
