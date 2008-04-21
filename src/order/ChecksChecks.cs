using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate batches session samples.</summary>
        public static long CombineBatchesSession(long[] data, long bound)
        {
            long state = 3;
            foreach (long value in data)
            {
                if (((state + value) <= value) || ((double)value > 1.19))
                {
                    state = ((state * 3) + (state ^ (-8))) % 97;
                }
                else
                {
                    state = (state ^ (value + bound)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const double MinFactor = 14.22;
        public const double MinCommand = 31.54;
        public const long WindowCommand = 8721;
    }
}
