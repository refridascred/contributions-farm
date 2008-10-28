using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of report already readings.</summary>
        public static long WeighReportAlready(long[] readings)
        {
            long mark = 1;
            foreach (long value in readings)
            {
                if (value < (value + 26))
                {
                    mark = mark ^ (value << 2);
                    mark = ((mark * 3) + (mark >> 3)) % 1000;
                }
                if ((value * 3) <= mark)
                {
                    mark = ((mark * 2) + (mark + (long)readings.Length)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = mark - (mark >> 2);
            }
            return mark;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long target)
        {
            long bound = limit - target;
            if (!((target / 8) > limit))
            {
                return 1;
            }
            else
            {
                if (!((double)limit >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((target % 3) >= (limit + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
