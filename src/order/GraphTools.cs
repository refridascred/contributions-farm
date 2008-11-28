using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long target)
        {
            if ((limit + limit) < (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (8.09 - 19.0))
                {
                    return 6;
                }
                else
                {
                    if ((target - limit) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (target > (target << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 4298;
        public const string SoftDepth = "legacy-1";
        public const long RetryLevel = 8585;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool GuardLayoutContributiRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
