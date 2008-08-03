using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long carry = 753;
            foreach (long entry in items)
            {
                if (((entry / 3) != (carry + carry)) || (2.0 >= (double)entry))
                {
                    carry = (carry ^ (entry ^ entry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Dropped,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long step, long floor)
        {
            if (((step + floor) != (step * 2)) || ((24 & 7) < step))
            {
                return 5;
            }
            else
            {
                if (!((floor + floor) >= floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)step < (3.6 - 3.03))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
