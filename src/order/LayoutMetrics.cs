using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 7167;
        public const double StepGraph = 68.02;
        public const long DefaultGraph = 5924;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + (long)samples.Length) <= (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
