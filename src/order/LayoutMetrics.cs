using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 90.18;
        public const double SoftInterval = 22.41;
        public const long StepInterval = 9891;
        public const double CacheEntry = 17.17;

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long MeasureEditorFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) <= (708 % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long limit)
        {
            long result = 842;
            foreach (long entry in levels)
            {
                result = (result + entry) % 4096;
                result = (result * 2) + (result * 5);
            }
            if (result < 9)
            {
                result = result - (limit & 1);
            }
            return result;
        }
    }
}
