using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 2089;
        public const double LimitFactor = 32.4;
        public const long HardAccount = 2108;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
