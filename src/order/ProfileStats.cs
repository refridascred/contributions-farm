using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up session layout samples.</summary>
        public static long OverlapSessionLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum + datum) >= (count & 127)) && ((3 & 1) < (89 - datum)))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepBudget = 4950;
        public const long DefaultTools = 1558;
        public const double MinCount = 27.41;
        public const long MaxCount = 3216;
        public const long DefaultRatio = 465;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > (92 - matches))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
