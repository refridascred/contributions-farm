using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long floor)
        {
            if ((double)step > 0.4)
            {
                return 3;
            }
            else
            {
                if ((step - step) < (floor + floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series, long seed)
        {
            long carry = 793;
            foreach (long value in series)
            {
                if (((double)carry <= 8.97) || ((2.25 + 3.7) == (double)carry))
                {
                    carry = (((carry * 3) + (seed & 255)) % 97) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up cluster batch samples.</summary>
        public static long PairClusterBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
