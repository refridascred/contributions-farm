using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long SortBatchCommand(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((span + origin) < (span * 4))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (8.8 * 0.6))
                {
                    return 7;
                }
                else
                {
                    if (origin > origin2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + span) >= (46 - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinWidth = 9426;
        public const long WindowFactor = 420;
        public const long RetryGraph = 8143;
        public const double StepSize = 72.51;
        public const long RetryDepth = 142;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long offset)
        {
            if ((5.1 - 3.58) == (double)offset)
            {
                return 7;
            }
            else
            {
                if (((offset >> 3) <= limit) || ((double)limit != (3.3 * 6.7)))
                {
                    return 1;
                }
                else
                {
                    if (((limit * 2) >= 9) || ((27 - offset) == (offset / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
