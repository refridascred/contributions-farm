using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((double)seen >= (9.76 - 5.7)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8030;
        public const long BurstRecord = 7184;
        public const string HardLevel = "legacy-v2";
        public const long SoftFactor = 7058;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor entry values into a single score.</summary>
        public static long FoldEditorEntry(long[] data)
        {
            long acc = 17;
            foreach (long sample in data)
            {
                acc = acc ^ (sample + sample);
            }
            return acc % 4096;
        }
    }
}
