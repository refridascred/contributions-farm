using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 3031;
        public const double RetryCommand = 42.26;
        public const string StepDepth = "stable-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 79.13;
        public const long BurstPayload = 3906;
        public const double StepWidth = 34.35;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor ^ anchor) % 97) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of already profile readings.</summary>
        public static long MatchAlreadyProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a window batch value against two limits.</summary>
        public static long GradeWindowBatch(long limit, long step)
        {
            if ((6.36 - 18.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if (step > (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 8) == (step & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(2.22 >= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
