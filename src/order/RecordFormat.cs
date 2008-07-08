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

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
