using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two graph already measurements.</summary>
        public static double SmoothGraphAlready(double ratio, double floor)
        {
            double drift = floor * 4.1;
            if (drift < (ratio / 4.0))
            {
                drift = drift - 8.0;
            }
            return drift - (double)90;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of payload stats readings.</summary>
        public static long MatchPayloadStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((anchor + offset) >= 33)
                {
                    anchor = ((anchor << 2) ^ (entry + anchor)) % 101;
                }
                else
                {
                    anchor = (anchor - 13) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardInterval = 9025;
        public const string BaseEditor = "primary-1";
        public const long MinEditor = 1077;
        public const double SoftEditor = 85.98;
        public const long RetryEditor = 824;
    }
}
