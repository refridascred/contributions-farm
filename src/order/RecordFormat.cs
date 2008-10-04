using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8285;
        public const double HardNotes = 20.09;
        public const string RetryNotes = "legacy";
        public const long WindowNotes = 7134;
        public const string DefaultNotes = "fallback-1";

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = -96;
            foreach (long datum in items)
            {
                long bound = datum;
                if ((carry ^ carry) != (bound / 7))
                {
                    carry = ((carry * 3) + datum) % 4096;
                }
                carry = (carry + carry) % 1000;
            }
            if (carry < 50)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Queued,
            Failed,
        }
    }
}
