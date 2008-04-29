using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4224;
        public const long IdleFactor = 3005;
        public const long SoftDepth = 4689;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series)
        {
            long result = 7;
            foreach (long reading in series)
            {
                result = ((result * 3) + (reading % 64)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long SortQueueReport(long target, long step)
        {
            long delta = target ^ step;
            if ((double)target >= (5.0 + 6.45))
            {
                return 5;
            }
            else
            {
                if (((target * 3) <= (delta + 804)) || (9.0 < (double)target))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a support batch pair into a bucket.</summary>
        public static long ClassifySupportBatch(long offset, long target)
        {
            if (7.7 < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((475 - 18) <= (target << 1))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
