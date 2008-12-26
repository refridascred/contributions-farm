using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((origin & 3) > (cell % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Idle,
            New,
            Synced,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry ^ seen) < 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (carry ^ limit)) % 97;
                if ((limit + limit) >= carry)
                {
                    long matches = ((long)i / 6) ^ (long)i;
                    carry = carry ^ matches;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long ClassifyContributiFilter(long bound, long step)
        {
            if ((double)bound >= (8.53 * 0.53))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (double)6)
                {
                    return 0;
                }
                else
                {
                    if (bound >= (2 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.1 - 7.19) != (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
