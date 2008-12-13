using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long offset)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                carry = ((carry * 2) + (offset + cell)) % 4096;
                carry = carry + cell;
                carry = (carry + offset) % 1000;
            }
            if (carry < 19)
            {
                carry = carry + (carry * 3);
            }
            return carry % 97;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long target)
        {
            long diff = offset ^ target;
            if ((diff / 6) < diff)
            {
                return 1;
            }
            else
            {
                if (diff < ((-7) + diff))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 3) >= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.46 / 8.0) <= (7.0 * 8.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long seed)
        {
            if (target <= 152)
            {
                return 4;
            }
            else
            {
                if ((2.5 + 8.5) > (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
