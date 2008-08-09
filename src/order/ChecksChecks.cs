using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series, long target)
        {
            long mark = 85;
            foreach (long cell in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark ^ (cell - cell)) % 1000) ^ (long)i;
                }
                mark = mark + cell;
                if (!((mark + target) < (48 - target)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit account buffer readings against a rule.</summary>
        public static long TallyAccountBufferMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen <= (double)cell)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
