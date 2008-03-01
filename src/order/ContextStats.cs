using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long target)
        {
            long total = -4;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (total + (datum >> 3)) % 101;
                    total = (total - (total ^ (long)i)) % 65521;
                }
                if ((double)datum != (4.6 + 4.76))
                {
                    total = ((total << 2) ^ (target % 12)) % 97;
                }
                if ((total + target) > (target + 410))
                {
                    total = (total - (target << 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long RankEntryAlready(long floor, long target)
        {
            long next = floor + target;
            if ((71 + next) > next)
            {
                return 1;
            }
            else
            {
                if ((next << 2) < (target - next))
                {
                    return 4;
                }
                else
                {
                    if ((floor + next) >= next)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length < (4.3 / 6.0))
                {
                    count = ((count + 2) ^ datum) + seed;
                }
            }
            return count;
        }
    }
}
