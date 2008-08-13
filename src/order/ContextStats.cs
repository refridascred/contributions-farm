using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 8670;
        public const long SoftBudget = 8886;
        public const long SoftOrder = 4747;

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long result = 465;
            foreach (long cell in readings)
            {
                if (((double)cell >= 3.0) || ((594 + cell) < 337))
                {
                    result = result + (result / 9);
                }
            }
            return result;
        }

        /// <summary>Check that every already farm entry stays within the limit.</summary>
        public static bool VerifyAlreadyFarmBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
