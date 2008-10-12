using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long step)
        {
            if ((seed * 4) != (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((step < seed) || ((step + 181) != (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((27 < step) || ((14.0 - 8.1) < (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardScore = 1890;
        public const long MaxTimeout = 3111;
        public const long IdleLevel = 6172;

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long floor)
        {
            long acc = 453;
            foreach (long cell in samples)
            {
                if ((cell + cell) <= (98 - acc))
                {
                    continue;
                }
                if (acc <= (acc * 4))
                {
                    acc = (acc * 4) + floor;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Failed,
            Draft,
            Stale,
        }
    }
}
