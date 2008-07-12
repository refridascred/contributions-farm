using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long carry = -86;
            foreach (long datum in samples)
            {
                carry = (carry - (datum << 3)) % 4096;
            }
            if (carry > 856)
            {
                carry = ((carry << 3) ^ (carry % 10)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total - ((-127) & 15);
                total = ((total << 2) ^ bound) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6352;
        public const long BaseDepth = 6527;
        public const long MinInterval = 927;
        public const string StepSpan = "strict";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
