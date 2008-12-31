using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryTimeout = 7477;
        public const long HardStats = 8878;
        public const long MaxInterval = 7138;
        public const long BaseBudget = 751;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((matches ^ matches) > datum) && ((double)matches <= (9.9 / 8.0))) || ((0.5 * 3.15) >= (double)limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((double)span < (double)19)
            {
                return 4;
            }
            else
            {
                if (((double)origin2 == (5.8 + 2.5)) || ((span + span) > (span + origin2)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
