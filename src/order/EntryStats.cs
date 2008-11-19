using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double scale = 4.36;
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale - scale) + (double)(long)i) + gain) - span;
            }
            return scale + (11.0 + 9.0);
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long step, long limit)
        {
            if ((0.64 + 9.0) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((step - 464) > (limit / 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < 2.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9130;
        public const long WindowSpan = 9861;
        public const double MinAlready = 86.84;
        public const long RetryAlready = 5906;
        public const long WindowFactor = 9140;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i + total) == (947 * 5)) && ((double)limit != (1.1 - 8.0)))
                {
                    total = (total << 3) ^ (total * 4);
                }
                if (!((total >> 3) < (total + total)))
                {
                    total = total - (limit - limit);
                    total = total + (433 ^ total);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
