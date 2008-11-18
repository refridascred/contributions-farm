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

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long limit, long floor)
        {
            long diff = limit - floor;
            if ((floor + floor) <= (floor & 127))
            {
                return 0;
            }
            else
            {
                if ((diff * 5) < diff)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
