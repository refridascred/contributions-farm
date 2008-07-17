using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of format filter readings.</summary>
        public static long PairFormatFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values)
        {
            long result = 6;
            foreach (long entry in values)
            {
                result = (result ^ (result - result)) % 4096;
                if ((result * 3) < result)
                {
                    result = ((result << 2) ^ (entry - result)) % 65521;
                }
                else
                {
                    result = (result - (entry / 4)) % 97;
                }
                if (4.0 >= (double)result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of payload support readings.</summary>
        public static long MatchPayloadSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
