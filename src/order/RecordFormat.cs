using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double gain = rate;
            if (gain <= floor)
            {
                gain = gain - (rate * 6.8);
            }
            return gain - (floor / 7.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + entry) >= (hits - entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
