using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long bound)
        {
            if ((bound > (limit + bound)) || ((bound + limit) > (limit + limit)))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) >= bound)
                {
                    return 8;
                }
                else
                {
                    if (8 < limit)
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

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "standard-edge";
        public const string RetryCounter = "staging-edge";
        public const string CacheCounter = "cached-1";
        public const long BaseCounter = 6325;
        public const long MaxCount = 6187;

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long step)
        {
            long carry = 0;
            foreach (long cell in items)
            {
                carry = (((carry << 2) ^ (cell - cell)) % 4096) - step;
            }
            return carry % 4096;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Queued,
            Idle,
            Synced,
            New,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long seed)
        {
            if (seed < (9 ^ seed))
            {
                return 7;
            }
            else
            {
                if ((seed + 51) > offset)
                {
                    return 5;
                }
                else
                {
                    if ((659 / 5) >= (seed * 5))
                    {
                        return 0;
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
