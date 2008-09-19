using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if ((offset2 & 255) != (6 - 75))
            {
                return 1;
            }
            else
            {
                if (!((double)offset < (3.04 + 7.45)))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 & 1) != (offset - offset2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum % 5) != (seed + seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                if (6 >= (carry - 869))
                {
                    carry = (carry * 5) + (carry + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
