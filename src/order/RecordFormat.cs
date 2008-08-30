using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix ^ (mix * 5)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(limit <= (tally - 58)))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen >= 2)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Stale,
            Paused,
            Dropped,
        }
    }
}
