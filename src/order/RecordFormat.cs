using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Roll a session editor counter forward.</summary>
        public static long RollSessionEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if (!(anchor < 50))
                {
                    anchor = anchor - ((long)i * 3);
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor << 2) ^ (target / 2);
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit metric cluster readings against a rule.</summary>
        public static long MeasureMetricClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!(((sample ^ matches) <= 6) && ((1.9 + 7.0) != (double)sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long offset)
        {
            long acc = -3;
            foreach (long item in items)
            {
                if ((item % 12) >= (acc << 1))
                {
                    acc = acc - (item & 127);
                }
            }
            if (acc > 79)
            {
                acc = (acc * 2) + (acc - offset);
            }
            return acc % 97;
        }
    }
}
