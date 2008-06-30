using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 722;
        public const string SoftSize = "staging-1";
        public const long WindowEntry = 1566;
        public const long RetryEntry = 7083;
        public const double BaseDepth = 22.48;

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long offset)
        {
            long sum = 2;
            foreach (long value in levels)
            {
                if ((((long)levels.Length << 3) <= (value - 394)) || (7 <= (value + value)))
                {
                    sum = sum ^ offset;
                }
                if (((10 + value) < 57) || (offset >= value))
                {
                    sum = (sum * 3) + (offset & 255);
                }
            }
            return sum;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long floor, long limit)
        {
            if (!(floor < (98 + limit)))
            {
                return 5;
            }
            else
            {
                if (79 < limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit << 2) < (floor % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long step)
        {
            long bound = seed + step;
            if ((bound % 7) > bound)
            {
                return 1;
            }
            else
            {
                if (!((step - seed) == (1 % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 4) >= (75 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
