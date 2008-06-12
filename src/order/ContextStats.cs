using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSpan = 3670;
        public const string HardContributi = "local-edge";
        public const double HardLevel = 70.88;
        public const string MaxContributi = "standard-edge";

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
