using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample > count) && ((sample / 8) >= (count + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry ^ 54) <= (matches - offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally != (double)483) || ((double)79 >= (double)target))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
