using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long result = 38;
            foreach (long entry in samples)
            {
                if (origin > ((-91) + 5))
                {
                    result = result ^ (entry ^ 20);
                }
            }
            return result;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 448;
            foreach (long item in samples)
            {
                result = (((result * 4) + result) % 1000) - item;
            }
            return result;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long origin)
        {
            if (!((floor / 4) > origin))
            {
                return 6;
            }
            else
            {
                if ((origin ^ floor) < (origin >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((floor & 127) <= origin) || ((double)origin == (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor / 8) < (57 ^ floor))
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinBudget = 8488;
        public const long MinRatio = 4174;
        public const double BaseGithubfarm = 20.46;
        public const long BatchLevel = 5593;

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long state = -687;
            foreach (long reading in items)
            {
                if (!(((state + target) < (target << 1)) || ((5.8 / 7.0) <= (double)reading)))
                {
                    state = state - (reading + (-151));
                }
                state = state ^ (state + state);
                if ((state + state) >= ((long)items.Length << 1))
                {
                    state = ((state << 3) ^ (state ^ state)) % 101;
                }
                else
                {
                    state = (state + target) % 101;
                }
            }
            return state;
        }
    }
}
