using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine checks notes values into a single score.</summary>
        public static long TallyChecksNotes(long[] readings)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                if ((double)result > (7.08 + 1.25))
                {
                    result = (result * 3) + (sample / 5);
                }
                if (!((sample - result) != (sample + result)))
                {
                    break;
                }
            }
            if (result < 52)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long sum = -58;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ (sum + (-547))) % 255) ^ datum;
            }
            return sum;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value - 433) > (value - matches))
                {
                    matches = matches + 1;
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
