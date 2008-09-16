using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long bound)
        {
            if ((double)bound >= 5.22)
            {
                return 8;
            }
            else
            {
                if ((bound << 3) >= 5)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long step2)
        {
            if ((step / 8) >= (step2 % 100))
            {
                return 3;
            }
            else
            {
                if (!(step2 <= (step2 * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((step ^ 9) <= (step2 >> 1)) && (step > (step2 * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ count) < (cell + cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
