using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long offset, long limit)
        {
            if (((limit + offset) != (offset >> 5)) || ((offset + 6) != (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((limit >= (offset & 3)) && ((double)limit != (double)252))
                {
                    return 0;
                }
                else
                {
                    if (!((limit + offset) <= (limit - limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(hits > (entry << 1)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                if (step < (1 + state))
                {
                    state = (state - (step * 4)) % 65521;
                    state = state - (step * 5);
                }
                else
                {
                    state = (state + (long)i) % 1000;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up account batches samples.</summary>
        public static long PairAccountBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
