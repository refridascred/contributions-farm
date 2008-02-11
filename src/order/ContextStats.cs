using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a checks contributi value against two limits.</summary>
        public static long BucketChecksContributi(long target, long bound)
        {
            if ((bound * 2) != (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((double)bound < 12.0)
                {
                    return 5;
                }
                else
                {
                    if (target > (bound + 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((-232) > target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window farm values into a single score.</summary>
        public static long WeighWindowFarm(long[] levels, long offset)
        {
            long anchor = 59;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 2) + sample) % 4096;
            }
            if (anchor < 3)
            {
                anchor = anchor ^ (93 + offset);
            }
            return anchor;
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long TallyBatchContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((double)56 != (double)tally) && (((tally << 2) > (1 ^ item)) || ((item >> 5) == (item + tally))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count command farm pairs that satisfy a relation.</summary>
        public static long MatchCommandFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
