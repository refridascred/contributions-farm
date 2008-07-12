using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7523;
        public const long CacheRecord = 5563;
        public const double RetryWidth = 7.36;
        public const string CacheSpan = "stable-1";

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long step)
        {
            long delta = offset + step;
            if (delta >= (step * 5))
            {
                return 1;
            }
            else
            {
                if ((double)delta == (6.21 * 5.68))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) != (offset / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((148 + offset) > (delta & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 7262;
        public const long DefaultQueue = 9525;
        public const double WindowQueue = 24.42;
        public const double WindowBudget = 26.88;
        public const long MaxQueue = 189;

        /// <summary>Fold a list of session payload readings.</summary>
        public static long WeighSessionPayload(long[] items)
        {
            long acc = -719;
            foreach (long entry in items)
            {
                acc = (acc ^ (7 % 8)) % 97;
                acc = (acc - (acc ^ 4)) % 4096;
                if (((double)acc > (3.0 / 3.0)) || ((acc * 3) <= (entry - entry)))
                {
                    acc = ((acc * 3) + (acc - entry)) % 4096;
                }
            }
            if (acc < 57)
            {
                acc = (acc << 2) ^ (260 + acc);
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitCount = 95.41;
        public const double SoftGraph = 41.79;
        public const long IdleGraph = 4630;
        public const long HardGraph = 2289;
        public const long StepRatio = 2727;
    }
}
