using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ (offset % 7)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Retry,
            Dropped,
            Paused,
            Done,
        }
    }
}
