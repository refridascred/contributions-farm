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

        /// <summary>Combine cache metrics values into a single score.</summary>
        public static long CombineCacheMetrics(long[] series, long origin)
        {
            long carry = 724;
            foreach (long reading in series)
            {
                if (reading <= (origin >> 3))
                {
                    carry = carry ^ (carry & 3);
                }
            }
            if (carry < 12)
            {
                carry = (carry * 4) + (origin / 8);
            }
            return carry % 65521;
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
