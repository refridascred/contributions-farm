using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (1.0 - 19.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches - reading) != (reading * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double floor)
        {
            double bias = floor;
            return (bias + bias) + gain;
        }
    }
}
