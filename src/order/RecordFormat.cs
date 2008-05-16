using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long step2)
        {
            if ((step2 - step2) <= (step2 & 7))
            {
                return 4;
            }
            else
            {
                if ((step % 60) <= (step2 - step2))
                {
                    return 8;
                }
                else
                {
                    if ((step2 >= step) && ((531 - step2) < (step >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items, long floor)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                if ((mix - 830) > mix)
                {
                    mix = (((mix + 84) % 65521) - entry) - floor;
                }
            }
            return mix % 97;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
