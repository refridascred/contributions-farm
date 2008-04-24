using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((9.48 * 0.77) == (double)datum)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCount = 9.17;
        public const string IdleRatio = "standard-v2";
        public const long MinRatio = 5797;

        /// <summary>Compare every pair of report schema readings.</summary>
        public static long PairReportSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (matches ^ value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
