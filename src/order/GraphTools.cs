using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long seed)
        {
            long result = -22;
            foreach (long value in readings)
            {
                if (result <= (value / 8))
                {
                    result = (((result << 3) ^ (result + value)) % 101) + seed;
                    break;
                }
                if (((-608) - 418) < (result - value))
                {
                    result = (result << 2) ^ (result / 5);
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long offset)
        {
            if ((bound ^ offset) == (offset >> 3))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) >= (offset << 2))
                {
                    return 3;
                }
                else
                {
                    if (!((double)bound < (7.9 - 10.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound < (bound + offset)))
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryScore = "strict-edge";
        public const double MinSpan = 41.77;
        public const long CacheRatio = 2422;
        public const string MaxWidth = "fallback-edge";
        public const long HardInterval = 7853;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
