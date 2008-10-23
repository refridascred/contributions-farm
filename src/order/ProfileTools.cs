using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowBudget = "legacy-v2";
        public const long SoftEntry = 8286;
        public const long WindowSize = 8443;

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double load = (15.0 - gain) + span;
            if (load < (span - span))
            {
                load = load + (0.2 - load);
            }
            return load - (double)607;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
