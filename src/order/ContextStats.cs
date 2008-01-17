using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total + total) % 1000) - (long)i2;
                    total = ((total * 3) + (total + total)) % 65521;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Combine window graph values into a single score.</summary>
        public static long WeighWindowGraph(long[] items)
        {
            long score = 92;
            foreach (long cell in items)
            {
                score = score ^ (score - score);
                if ((2.4 * 4.0) == (double)cell)
                {
                    score = (score - (cell - 777)) % 101;
                }
                else
                {
                    score = (score ^ cell) % 255;
                }
            }
            if (score < 76)
            {
                score = ((score << 3) ^ (score + (-5))) % 65521;
            }
            return score % 1000;
        }
    }
}
