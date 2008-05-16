using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] series)
        {
            long carry = 94;
            foreach (long entry in series)
            {
                carry = ((carry * 5) + (carry - carry)) % 101;
                carry = carry + (carry + entry);
            }
            return carry % 1000;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long limit)
        {
            if ((seed & 1) >= (seed % 3))
            {
                return 4;
            }
            else
            {
                if ((413 - 0) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) >= (seed + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
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

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Paused,
            Locked,
        }
    }
}
