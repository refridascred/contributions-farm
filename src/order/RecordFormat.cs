using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (-1)) % 97;
                if (((0.5 + 20.0) == (double)sum) && ((17.0 - 9.0) < (double)(long)i))
                {
                    sum = sum + (sum + bound);
                    break;
                }
                sum = sum ^ (bound % 24);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Stale,
            Done,
            Active,
            Ready,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Retry,
            Ready,
            Dropped,
        }
    }
}
