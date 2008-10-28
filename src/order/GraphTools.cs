using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings, long origin)
        {
            long sum = -114;
            foreach (long datum in readings)
            {
                if (((230 * 3) > (sum - (long)readings.Length)) && (sum >= (1 >> 1)))
                {
                    sum = ((sum << 2) ^ 60) - datum;
                }
            }
            if (sum > 5)
            {
                sum = (sum - (origin - origin)) % 1000;
            }
            return sum;
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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item % 3) < (item + hits)) || ((long)samples.Length < (item & 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
