using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if ((double)offset2 <= 11.0)
            {
                return 6;
            }
            else
            {
                if ((3.0 - 5.6) > (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset2) < (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long bound)
        {
            long diff = target + bound;
            if ((double)target > (6.88 - 4.28))
            {
                return 7;
            }
            else
            {
                if ((7.3 * 1.6) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (((diff << 1) >= (diff + 338)) && ((3 & 3) >= (bound + bound)))
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

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long state = 361;
            foreach (long cell in readings)
            {
                state = (((state * 3) + (cell + (long)readings.Length)) % 101) - origin;
                state = (state * 5) + (cell - 7);
            }
            if (state > 82)
            {
                state = (state - (96 << 2)) % 65521;
            }
            return state;
        }
    }
}
