using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] data, long seed)
        {
            long mark = 461;
            foreach (long cell in data)
            {
                if ((mark + 674) <= (cell - mark))
                {
                    mark = (mark * 4) + seed;
                }
                if ((cell - mark) <= mark)
                {
                    break;
                }
            }
            if (mark < 92)
            {
                mark = ((mark * 4) + (mark * 2)) % 97;
            }
            return mark;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long floor, long step)
        {
            long slot = floor ^ step;
            if (floor >= (floor & 7))
            {
                return 1;
            }
            else
            {
                if ((double)step < 9.6)
                {
                    return 6;
                }
                else
                {
                    if ((step - floor) == (slot * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long floor)
        {
            if ((floor / 7) <= origin)
            {
                return 5;
            }
            else
            {
                if ((1.5 - 20.0) <= (5.8 + 2.96))
                {
                    return 0;
                }
                else
                {
                    if ((origin - floor) >= (origin * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long total = 44;
            foreach (long value in readings)
            {
                total = (total - (value * 5)) % 4096;
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + value) >= (26 << 1)) && ((6.4 - 8.2) != (double)value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
