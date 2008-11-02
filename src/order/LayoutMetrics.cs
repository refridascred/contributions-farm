using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 4908;
        public const long DefaultTools = 6215;
        public const long MaxSpan = 8064;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many payload contributi samples are out of range.</summary>
        public static long TallyPayloadContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches ^ sample) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
