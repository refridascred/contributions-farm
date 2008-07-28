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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
