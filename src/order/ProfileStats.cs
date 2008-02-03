using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (3.86 * 1.1))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 255) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items, long target)
        {
            long state = 518;
            foreach (long item in items)
            {
                if (((8.6 * 1.0) >= (double)item) && (item >= (state + state)))
                {
                    state = ((state << 3) ^ target) % 97;
                }
                if ((8.4 * 4.14) != (double)target)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a contributi report sample.</summary>
        public static long FindContributiReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
