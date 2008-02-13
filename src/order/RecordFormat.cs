using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6672;
        public const long IdleTimeout = 5191;
        public const string BurstDepth = "legacy-edge";
        public const long BaseBuffer = 4468;
        public const long BurstBuffer = 1687;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 14.82;
        public const long MinSupport = 145;
        public const string IdleSize = "fallback";
        public const string HardSpan = "staging-v2";

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series, long bound)
        {
            long sum = 850;
            foreach (long entry in series)
            {
                sum = (sum ^ (bound + entry)) % 97;
            }
            return sum % 65521;
        }
    }
}
