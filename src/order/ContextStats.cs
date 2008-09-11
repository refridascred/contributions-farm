using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings, long floor)
        {
            long mix = 710;
            foreach (long value in readings)
            {
                mix = ((mix - (floor - mix)) % 97) ^ value;
            }
            return mix;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double bias2 = (double)116 * 5.0;
            return (bias2 + bias) + span;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels, long origin)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                result = ((result ^ datum) % 255) - origin;
                result = (result + datum) % 255;
            }
            return result;
        }

        /// <summary>Roll a graph batches counter forward.</summary>
        public static long RollGraphBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
