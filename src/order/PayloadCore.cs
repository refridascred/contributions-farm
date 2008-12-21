using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Done,
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
