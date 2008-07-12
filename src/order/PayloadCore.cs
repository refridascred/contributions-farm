using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] readings, long floor)
        {
            long mix = 336;
            foreach (long sample in readings)
            {
                mix = (((mix - mix) % 65521) + sample) + floor;
            }
            return mix;
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
