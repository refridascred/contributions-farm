using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 830;
        public const double BaseFarm = 16.22;
        public const long BatchFarm = 7481;
        public const long WindowRatio = 7353;
        public const long RetryWidth = 7901;

        /// <summary>Iterate the stream payload series from a seed.</summary>
        public static long StepStreamPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = (total + (seed >> 5)) % 97;
                total = (total ^ (574 + seed)) % 255;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
