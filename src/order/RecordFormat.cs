using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] data, long limit)
        {
            long sum = 93;
            foreach (long datum in data)
            {
                if ((double)sum == (20.0 * 1.77))
                {
                    sum = (sum * 3) + (datum * 3);
                }
                if (!!((datum % 97) > datum))
                {
                    sum = (sum ^ (sum - limit)) % 1000;
                }
                if ((((-750) + datum) != (sum << 2)) || ((1.71 * 3.7) == (double)(long)data.Length))
                {
                    sum = (sum ^ datum) % 4096;
                }
                else
                {
                    sum = (sum + limit) % 97;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                mark = (mark + (587 & 15)) % 97;
                mark = (mark + mark) % 1000;
                if (!((mark * 3) <= (datum % 64)))
                {
                    mark = mark ^ (datum + datum);
                }
            }
            if (mark > 9)
            {
                mark = (mark - (mark >> 4)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
