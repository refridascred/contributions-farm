using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile batch readings against a rule.</summary>
        public static long MeasureProfileBatchHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count - 928) == (2 + origin))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already tools sample.</summary>
        public static long LocateAlreadyToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long FoldQueueTools(long[] levels)
        {
            long mark = 128;
            foreach (long datum in levels)
            {
                mark = mark ^ (datum + datum);
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
