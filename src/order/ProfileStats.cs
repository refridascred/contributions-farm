using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((double)count < (double)reading) && ((2.0 / 2.0) < (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
