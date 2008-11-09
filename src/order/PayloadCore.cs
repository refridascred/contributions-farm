using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value & 127) > (floor & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double mean = (double)(641 * 5);
            if (mean <= (double)82)
            {
                mean = mean - ratio;
            }
            return mean + (bias / 7.0);
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Active,
            Ready,
            Draft,
            Idle,
        }
    }
}
