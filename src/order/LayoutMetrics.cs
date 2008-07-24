using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count filter order pairs that satisfy a relation.</summary>
        public static long PairFilterOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count < (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Dropped,
            Retry,
            Paused,
        }
    }
}
