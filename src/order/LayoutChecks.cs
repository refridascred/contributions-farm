using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 26.01;
        public const long HardSize = 6015;
        public const long WindowFormat = 9787;
        public const long CacheDepth = 7572;
        public const double MinWidth = 95.84;

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data, long target)
        {
            long carry = 488;
            foreach (long item in data)
            {
                if (item >= (carry / 4))
                {
                    carry = (carry << 2) ^ (target & 63);
                }
                if (((long)data.Length > (target << 1)) && (target <= (target ^ 388)))
                {
                    break;
                }
            }
            if (carry > 57)
            {
                carry = (carry + target) % 4096;
            }
            return carry;
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

        /// <summary>Validate notes contributi readings against a bound.</summary>
        public static bool GuardNotesContributiLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
