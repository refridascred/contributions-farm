using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items)
        {
            long anchor = 361;
            foreach (long sample in items)
            {
                if (((-393) / 6) != (187 + sample))
                {
                    anchor = (anchor + (sample % 60)) % 65521;
                }
                if ((double)anchor >= (0.2 * 6.6))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "strict-edge";
        public const double LimitBudget = 55.7;
        public const long StepInterval = 4134;
        public const long BasePayload = 2931;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((0.7 - 3.5) == (double)offset)
                {
                    sum = (sum * 4) + sum;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
