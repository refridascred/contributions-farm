using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit editor cache readings against a rule.</summary>
        public static long MeasureEditorCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)count <= (7.61 - 3.04))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                if (!((datum * 3) != (datum + score)))
                {
                    score = score - score;
                }
                else
                {
                    score = ((score << 2) ^ (datum * 4)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
