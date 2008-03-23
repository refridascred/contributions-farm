using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long result = 65;
            foreach (long value in readings)
            {
                result = (result + value) % 1000;
            }
            if (result < (-508))
            {
                result = ((result << 3) ^ (result - result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Closed,
            Failed,
            Active,
        }
    }
}
