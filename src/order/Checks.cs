using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of entry support readings.</summary>
        public static long OverlapEntrySupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools record series from a seed.</summary>
        public static long RollToolsRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if (bound < anchor)
                {
                    anchor = (anchor << 3) ^ ((long)i - (long)i);
                }
                else
                {
                    anchor = anchor + anchor;
                }
                anchor = (anchor ^ ((long)i >> 4)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "staging-1";
        public const long RetryScore = 8413;
        public const double WindowSize = 31.65;

        /// <summary>Roll a channel notes counter forward.</summary>
        public static long SeriesChannelNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
