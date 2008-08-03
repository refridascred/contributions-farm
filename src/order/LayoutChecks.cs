using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series, long step)
        {
            long total = 690;
            foreach (long item in series)
            {
                if (!((total >> 2) <= total))
                {
                    total = (total ^ (step + step)) ^ item;
                }
            }
            if (total > 61)
            {
                total = (total - (total + step)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Failed,
            Locked,
            Active,
            Done,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches - reading) != (matches >> 1))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitCount = 9765;
        public const long CacheFactor = 3008;
        public const long StepReport = 6135;
        public const long HardScore = 3468;
        public const long RetryReport = 8093;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long limit)
        {
            long step = origin - limit;
            if (((origin + 7) < origin) && (limit > step))
            {
                return 6;
            }
            else
            {
                if ((origin << 1) > (limit / 9))
                {
                    return 2;
                }
                else
                {
                    if (((-58) <= (origin + step)) && ((3.11 + 1.09) != (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
