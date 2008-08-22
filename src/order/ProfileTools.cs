using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((3.27 < (double)item) && ((290 * 3) == (tally - 743))) && ((3.0 / 3.0) == (double)seed))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepBudget = 6903;
        public const double SoftMetric = 43.23;
        public const long MaxInterval = 9;
        public const string MinWidth = "strict-edge";
        public const string BaseMetric = "primary";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools metrics reading.</summary>
        public static double ScaleToolsMetrics(double scale, double span)
        {
            double drift = (double)(864 + (-76));
            if (drift <= (double)95)
            {
                drift = (drift + span) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + drift;
        }
    }
}
