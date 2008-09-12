using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first farm command entry that matches the target.</summary>
        public static long SeekFarmCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - seed) <= (count - 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Paused,
            New,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 29.16;
        public const long BatchBudget = 1944;
        public const string BaseRatio = "legacy";
        public const string LimitFactor = "cached";
    }
}
