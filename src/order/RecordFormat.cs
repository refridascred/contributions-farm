using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a report channel counter forward.</summary>
        public static long DeriveReportChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state - state) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics order samples are out of range.</summary>
        public static long TallyMetricsOrderHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) != (origin + origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long step)
        {
            if ((69 - 19) < (step + offset))
            {
                return 1;
            }
            else
            {
                if (!((step - offset) >= 74))
                {
                    return 8;
                }
                else
                {
                    if ((step << 1) >= (4 % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
