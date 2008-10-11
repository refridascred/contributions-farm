using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = result ^ 56;
                result = (result - (result + seed)) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            Idle,
            Failed,
            New,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
