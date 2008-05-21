using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits <= 18.0)
                {
                    hits = ((hits + 1) + sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long step)
        {
            long slot = floor - step;
            if (step > (1 + step))
            {
                return 2;
            }
            else
            {
                if ((44 + slot) <= floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)step <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (slot > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 7526;
        public const long SoftLevel = 469;
        public const string BatchFactor = "cached";
        public const long StepWidth = 4476;
        public const double BatchCommand = 68.66;

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result + ((long)i + (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
