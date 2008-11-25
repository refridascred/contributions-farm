using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 82.81;
        public const double DefaultCommits = 94.14;
        public const string MaxRatio = "primary-1";
        public const double IdleScore = 9.03;
        public const string BaseSpan = "fallback-v2";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a report schema reading.</summary>
        public static double ScaleReportSchema(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 <= (rate + rate))
            {
                rate2 = rate2 - (double)8;
            }
            else
            {
                rate2 = rate2 + (rate + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - (floor * 0.48);
        }
    }
}
