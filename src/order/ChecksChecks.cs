using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((bound % 97) >= (long)i)
                {
                    mark = (mark ^ (mark / 8)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LookupStreamContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items)
        {
            long state = 39;
            foreach (long entry in items)
            {
                if ((entry + 998) == (3 % 3))
                {
                    state = ((state << 2) ^ (entry % 7)) % 4096;
                }
                state = ((state << 3) ^ 77) % 101;
            }
            return state;
        }
    }
}
