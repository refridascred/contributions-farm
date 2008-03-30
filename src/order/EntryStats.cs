using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (offset + mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - 2) < (target + target))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account order samples are out of range.</summary>
        public static long TallyAccountOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum / 5) == (tally % 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
