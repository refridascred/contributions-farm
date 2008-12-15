using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ ((long)i - (long)i)) % 97;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                sum = sum - (7 & 31);
                if ((sum * 5) > (entry + sum))
                {
                    sum = (sum ^ (317 >> 4)) % 101;
                }
            }
            return sum % 65521;
        }
    }
}
