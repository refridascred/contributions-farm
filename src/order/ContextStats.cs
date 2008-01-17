using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 76.87;
        public const long BatchPayload = 7683;
        public const long IdleScore = 323;
        public const long WindowCount = 7160;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long seed)
        {
            if (!((seed + step) != (step * 3)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) >= (753 + 563))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

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
