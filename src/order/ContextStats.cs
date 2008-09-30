using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target << 2) < (5 ^ target)) || ((total * 4) < (total / 5)))
                {
                    total = total + (target & 63);
                    total = ((total * 5) + ((-5) << 2)) % 97;
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data, long origin)
        {
            long mark = 97;
            foreach (long entry in data)
            {
                mark = (mark ^ (entry % 7)) - origin;
            }
            return mark % 1000;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
