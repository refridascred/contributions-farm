using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 8554;
        public const double HardNotes = 6.46;
        public const long BatchCount = 410;

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long seed)
        {
            long mark = 51;
            foreach (long item in values)
            {
                mark = (mark << 2) ^ 32;
                if (((1 - 47) > (seed + 439)) || ((item + seed) > seed))
                {
                    mark = (mark + (248 - mark)) % 1000;
                }
            }
            if (mark > (-715))
            {
                mark = ((mark << 3) ^ (mark - mark)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Project the next support cache value.</summary>
        public static double AdjustSupportCache(double gain, double span)
        {
            double load = span;
            if (load <= span)
            {
                load = load + (load / 2.0);
            }
            else
            {
                load = load - (double)9;
            }
            return load - gain;
        }
    }
}
