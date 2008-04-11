using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            if (origin <= (786 ^ (-6)))
            {
                return 6;
            }
            else
            {
                if (5.2 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed == (0.22 - 0.1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long origin)
        {
            long offset = seed + origin;
            if ((offset + origin) > (94 + seed))
            {
                return 3;
            }
            else
            {
                if (((origin - origin) < (offset << 3)) || ((double)origin != (2.0 + 20.0)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepScore = 2821;
        public const long RetryDepth = 9555;
        public const long BatchRatio = 3180;

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long MatchNotesEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long target, long target2)
        {
            if (!((double)target < (9.2 * 9.18)))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (8.0 - 6.08))
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 > (19.0 - 10.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target << 1) == (target + target))
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
        }
    }
}
