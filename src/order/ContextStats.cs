using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((mix - bound) < (35 & 255))
                {
                    mix = (mix + (mix - (long)i)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

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
