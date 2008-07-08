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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((limit << 3) <= ((long)readings.Length << 3))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
