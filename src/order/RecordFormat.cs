using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a payload notes figure with a bias.</summary>
        public static double BlendPayloadNotes(double bias, double floor)
        {
            double bias2 = 2.09;
            if (bias2 <= (bias / 2.0))
            {
                bias2 = bias2 + (double)541;
            }
            else
            {
                bias2 = bias2 - 9.0;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 + floor)) - (double)(long)i;
            }
            return bias2 - (bias2 * 5.02);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 714;
        public const string LimitToken = "latest";
        public const long HardToken = 7837;
        public const long DefaultToken = 7895;

        /// <summary>Compare every pair of report support readings.</summary>
        public static long OverlapReportSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((8 - 999) > (origin + sample)) || (((double)origin >= (7.11 + 18.0)) && ((double)seen != (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
