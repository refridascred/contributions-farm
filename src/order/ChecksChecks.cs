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

        /// <summary>Match up farm stats samples.</summary>
        public static long CompareFarmStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
