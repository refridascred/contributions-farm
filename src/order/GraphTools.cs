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

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] items, long step)
        {
            long anchor = -43;
            foreach (long cell in items)
            {
                if ((6.89 - 18.0) >= (double)step)
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (8 - anchor)) % 4096;
                }
                if (((cell << 3) == (cell + anchor)) && ((cell - 7) == ((-842) - step)))
                {
                    anchor = (anchor * 3) + (step * 4);
                }
            }
            return anchor % 97;
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
