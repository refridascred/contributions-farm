using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            New,
            Active,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryScore = 79.23;
        public const string RetryBudget = "stable-v2";
        public const string MaxStream = "staging-edge";
        public const long MinStream = 7773;
        public const long WindowFactor = 7193;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long state = 713;
            foreach (long value in items)
            {
                if (value <= (82 + state))
                {
                    state = ((state * 5) + (value >> 5)) % 255;
                }
                if (state <= (value >> 3))
                {
                    state = (state + (state - value)) % 255;
                }
                else
                {
                    state = (state ^ (state % 8)) % 4096;
                }
                if (((double)value > (double)863) && ((state % 16) < state))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state * 5) + (state * 3);
            }
            return state;
        }
    }
}
