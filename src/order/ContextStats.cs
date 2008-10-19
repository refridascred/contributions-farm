using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mark >= (8.99 + 6.1))
                {
                    mark = (mark ^ origin) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long bound, long offset)
        {
            if (bound >= (bound ^ bound))
            {
                return 5;
            }
            else
            {
                if (offset <= 46)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((floor + datum) < matches) || ((floor + floor) <= (datum * 4))) && ((datum & 1) != (matches + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
