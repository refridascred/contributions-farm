using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "primary";
        public const string WindowBuffer = "alpha-1";
        public const long SoftBuffer = 2155;
        public const long CacheBuffer = 6734;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long result = 15;
            foreach (long value in values)
            {
                if ((double)(long)values.Length <= (4.8 + 7.8))
                {
                    result = result ^ (bound - value);
                }
            }
            return result;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((-337) >> 2) >= (cell ^ 0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
