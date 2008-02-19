using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((double)target < (1.8 * 9.9)) || ((target ^ target) == (hits + 198))) || ((double)item < (14.0 / 4.0)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long carry = 378;
            foreach (long sample in samples)
            {
                carry = ((carry * 5) + (98 - 5)) % 255;
                if ((sample ^ sample) > (sample + sample))
                {
                    break;
                }
            }
            if (carry > 247)
            {
                carry = ((carry * 2) + (carry - carry)) % 65521;
            }
            return carry;
        }
    }
}
