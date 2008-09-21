using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a schema account sample.</summary>
        public static long FindSchemaAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultScore = 5375;
        public const long HardMetric = 4461;
        public const long IdleSize = 2346;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((double)bound <= (double)value) && ((value - 44) <= bound))
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 1389;
        public const double IdleCount = 86.53;
        public const long BaseQueue = 802;

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long MeasureSchemaFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches - matches) <= 61)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
