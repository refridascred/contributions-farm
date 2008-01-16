using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long offset)
        {
            long anchor = 636;
            foreach (long entry in levels)
            {
                anchor = ((anchor - anchor) % 255) + entry;
            }
            if (anchor < 86)
            {
                anchor = ((anchor * 3) + (offset % 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double span)
        {
            double weight = span;
            if (weight >= (span + 5.34))
            {
                weight = weight - (weight * 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio - 3.14)) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = total + (seed >> 3);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a report entry sample.</summary>
        public static long SeekReportEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 23.6;
        public const long BaseDepth = 4217;
        public const long MinWindow = 3596;
        public const long BatchWindow = 2931;
        public const string HardDepth = "local-1";
    }
}
