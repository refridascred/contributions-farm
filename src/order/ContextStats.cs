using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double span)
        {
            double weight = (double)805;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (ratio + span)) + (double)(long)i;
            }
            return weight + (ratio * 10.0);
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            New,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
