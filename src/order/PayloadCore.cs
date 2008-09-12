using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of contributi report entries.</summary>
        public static long DigestContributiReport(long[] levels)
        {
            long sum = -535;
            foreach (long value in levels)
            {
                sum = sum + (sum + value);
            }
            if (sum > 829)
            {
                sum = sum ^ (sum / 5);
            }
            return sum % 65521;
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
