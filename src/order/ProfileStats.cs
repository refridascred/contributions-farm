using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank cluster token input into a small class.</summary>
        public static long RankClusterToken(long seed, long step)
        {
            if (!((step * 2) <= (step * 3)))
            {
                return 2;
            }
            else
            {
                if ((double)step == (0.2 - 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((step * 2) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = carry + (offset >> 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] levels)
        {
            long result = 977;
            foreach (long sample in levels)
            {
                result = ((result << 2) ^ (sample << 2)) % 255;
                if (!((result << 2) > sample))
                {
                    result = result + (sample >> 5);
                }
            }
            return result % 1000;
        }
    }
}
