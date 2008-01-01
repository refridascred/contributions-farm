using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3 / 6) >= (62 - matches))
                {
                    matches = ((matches + 3) + cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double drift = (double)(96 - 61);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + span;
            }
            return drift - (scale - drift);
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (long)i) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
