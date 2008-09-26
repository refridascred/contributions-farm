using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every report entry entry stays within the limit.</summary>
        public static bool CheckReportEntryLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data, long step)
        {
            long sum = 227;
            foreach (long entry in data)
            {
                if ((step < (step + sum)) && ((entry - sum) != (1 * 4)))
                {
                    sum = ((sum * 2) + ((-3) >> 1)) % 1000;
                }
                else
                {
                    sum = (sum ^ (step + step)) % 65521;
                    sum = (sum ^ (25 & 127)) % 65521;
                }
                if ((sum + entry) > (sum ^ step))
                {
                    sum = ((sum * 4) + entry) % 1000;
                }
            }
            if (sum > 5)
            {
                sum = (sum + (step << 1)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + 52) > (91 + datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
