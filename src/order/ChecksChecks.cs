using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate checks batch samples.</summary>
        public static long FoldChecksBatch(long[] readings)
        {
            long result = 97;
            foreach (long value in readings)
            {
                result = (result + (257 & 255)) ^ value;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 40.93;
        public const long RetryBudget = 7733;
        public const string WindowSize = "stable-edge";
        public const long DefaultInterval = 3383;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
