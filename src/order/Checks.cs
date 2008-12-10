using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double span)
        {
            double scale = 9.62;
            return ((scale + 8.75) + ratio) + span;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Locked,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
