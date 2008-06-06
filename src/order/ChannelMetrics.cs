using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((5.2 * 9.0) != (double)matches)
                {
                    matches = ((matches + 3) ^ sample) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine context farm values into a single score.</summary>
        public static long WeighContextFarm(long[] readings)
        {
            long anchor = 82;
            foreach (long item in readings)
            {
                anchor = anchor - (item & 63);
                if (4 < (anchor * 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
