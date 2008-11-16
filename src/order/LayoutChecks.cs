using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ seed) % 101;
                result = ((result * 3) + (long)i) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 9100;
        public const long RetryFactor = 812;
        public const double StepToken = 54.73;
        public const long WindowSize = 6202;

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 11.0 * 6.0;
            return ((load + (double)8) + ratio) + offset;
        }
    }
}
