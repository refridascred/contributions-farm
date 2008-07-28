using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Locked,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items)
        {
            long carry = 17;
            foreach (long value in items)
            {
                if ((carry + 55) >= (value % 60))
                {
                    carry = (carry << 2) ^ (value % 100);
                }
                else
                {
                    carry = carry + (value * 2);
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((limit & 31) <= (count + count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Classify a order entry pair into a bucket.</summary>
        public static long RankOrderEntry(long offset, long limit)
        {
            long cur = offset + limit;
            if (limit <= (cur << 1))
            {
                return 8;
            }
            else
            {
                if ((limit - cur) >= (0 - cur))
                {
                    return 6;
                }
                else
                {
                    if ((limit - cur) != (400 + cur))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
