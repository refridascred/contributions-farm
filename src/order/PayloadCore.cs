using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series)
        {
            long mix = 67;
            foreach (long value in series)
            {
                mix = mix ^ (value & 31);
                if ((value * 5) <= mix)
                {
                    mix = (mix << 3) ^ (mix & 15);
                }
                else
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            return mix;
        }

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry >= (entry + count))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
