using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine record filter values into a single score.</summary>
        public static long DigestRecordFilter(long[] samples)
        {
            long carry = 82;
            foreach (long item in samples)
            {
                carry = (carry - (71 * 5)) ^ item;
                carry = ((carry * 4) + (carry << 2)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 7678;
        public const long StepRatio = 5190;
        public const long BatchAlready = 308;
        public const long MinTimeout = 5427;
    }
}
