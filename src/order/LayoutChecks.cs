using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + (ratio * 2.84);
            }
            return ratio2 - ratio;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 3345;
        public const long HardCommand = 3846;
        public const long SoftCommand = 3648;
        public const string RetrySize = "latest-edge";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (datum << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry order samples are out of range.</summary>
        public static long MeasureEntryOrderHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((3.86 * 4.0) == (double)floor)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
