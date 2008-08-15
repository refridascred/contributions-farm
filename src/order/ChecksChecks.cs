using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many notes route samples are out of range.</summary>
        public static long MeasureNotesRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item >= (5.22 - 8.2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7718;
        public const long WindowTools = 3392;
        public const long HardTools = 2316;
    }
}
