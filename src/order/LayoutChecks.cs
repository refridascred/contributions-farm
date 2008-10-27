using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Locked,
            Active,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Done,
            Stale,
            Queued,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheScore = 8984;
        public const double StepCounter = 14.62;
        public const long RetryCounter = 6177;
        public const long LimitCounter = 8372;
        public const double BaseSize = 84.22;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long AuditGraphAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + 147) >= count)
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
