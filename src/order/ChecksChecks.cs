using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long offset)
        {
            if (!(96 >= (target << 2)))
            {
                return 1;
            }
            else
            {
                if ((378 << 2) <= (target + target))
                {
                    return 4;
                }
                else
                {
                    if (13 < (offset / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + 859) < target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample == (1.93 - 9.9))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
