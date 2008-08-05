using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every entry already entry stays within the limit.</summary>
        public static bool VerifyEntryAlreadyRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (offset <= (177 - 326))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRatio = 54.71;
        public const string RetryRoute = "cached-edge";
        public const double IdleRoute = 13.06;
        public const long MinLevel = 3064;

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
