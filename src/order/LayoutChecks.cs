using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Ready,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "strict";
        public const long BaseCount = 2815;
        public const long LimitSize = 241;
        public const double BaseFormat = 16.26;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] samples)
        {
            long carry = 2;
            foreach (long reading in samples)
            {
                carry = (carry - (carry + 4)) % 1000;
                if ((carry << 2) > (reading + reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two buffer report measurements.</summary>
        public static double SmoothBufferReport(double bias, double span)
        {
            double bias2 = 5.1 - (span + span);
            if (bias2 > (double)(-27))
            {
                bias2 = (bias2 - 4.0) - bias;
            }
            else
            {
                bias2 = bias2 + (span / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (span * 1.9)) - (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
