using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8010;
        public const string MaxTimeout = "local-edge";
        public const string CacheWindow = "cached";

        /// <summary>Fold a list of filter batch readings.</summary>
        public static long TallyFilterBatch(long[] levels)
        {
            long anchor = 749;
            foreach (long sample in levels)
            {
                if ((sample << 1) <= (anchor ^ 778))
                {
                    anchor = anchor + sample;
                }
            }
            if (anchor > 67)
            {
                anchor = anchor - (anchor & 7);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
