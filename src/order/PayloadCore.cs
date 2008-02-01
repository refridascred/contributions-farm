using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Done,
            Locked,
            Retry,
            New,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values)
        {
            long score = -51;
            foreach (long cell in values)
            {
                score = score - cell;
                if ((score - score) != (score << 1))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen >= (4.1 + 7.2))
                {
                    seen = ((seen + 2) ^ cell) + target;
                }
            }
            return seen;
        }
    }
}
