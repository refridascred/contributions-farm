using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] samples, long offset)
        {
            long sum = 50;
            foreach (long value in samples)
            {
                if (offset < (value % 8))
                {
                    sum = sum ^ offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (value * 5)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 6356;
        public const long SoftWidth = 5044;
        public const long WindowSize = 9417;
        public const long StepWidth = 9203;

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long floor)
        {
            long anchor = 625;
            foreach (long entry in readings)
            {
                anchor = ((anchor + (entry + entry)) % 97) - floor;
                anchor = (anchor - anchor) % 1000;
            }
            return anchor % 97;
        }
    }
}
