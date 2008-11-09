using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long target)
        {
            if (((double)offset == (8.5 / 4.0)) || ((double)target > (9.92 + 20.0)))
            {
                return 6;
            }
            else
            {
                if ((target % 64) < (offset << 1))
                {
                    return 1;
                }
                else
                {
                    if (!((offset - offset) == (target / 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > (offset >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Look up the position of a window route sample.</summary>
        public static long LookupWindowRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3388;
        public const long RetryDepth = 6621;
        public const string MinWidth = "standard-1";
        public const string RetrySchema = "stable-1";
        public const string LimitFactor = "standard-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowTimeout = 48.33;
        public const double MaxGithubfarm = 38.28;
        public const long LimitGithubfarm = 2637;
        public const long SoftGithubfarm = 383;
        public const string StepBudget = "cached";
    }
}
