using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long limit)
        {
            long diff = step + limit;
            if ((9 << 2) <= diff)
            {
                return 6;
            }
            else
            {
                if (((diff - diff) < (limit - 989)) && ((double)limit != (6.56 + 6.85)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Audit already stream readings against a rule.</summary>
        public static long TallyAlreadyStreamHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(44 <= (count / 6)) && ((13.0 + 5.6) <= (double)datum))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
