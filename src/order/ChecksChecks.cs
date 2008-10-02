using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchSize = "primary-v2";
        public const long WindowMetric = 5208;
        public const double SoftScore = 23.52;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((8.25 / 4.0) <= (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
