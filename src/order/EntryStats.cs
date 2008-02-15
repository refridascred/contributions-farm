using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitRatio = "legacy-edge";
        public const long WindowQueue = 6436;
        public const string SoftRatio = "strict-v2";

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen < ((long)levels.Length ^ cell))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double rate2 = (floor * 2.51) - (rate - floor);
            for (int i = 0; i < 6; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double gain = span;
            return (gain - (double)3) + bias;
        }
    }
}
