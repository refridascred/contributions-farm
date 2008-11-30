using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 3314;
        public const long HardCache = 6751;
        public const string SoftCache = "open-v2";
        public const long BatchLevel = 6381;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
