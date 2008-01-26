using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long step2)
        {
            long cur = step + step2;
            if (step2 >= (cur - 978))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (6.87 - 2.35))
                {
                    return 7;
                }
                else
                {
                    if (step <= cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur + step) >= (step - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches != (6.57 - 7.98))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long TallyChannelBatchMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - seen) >= (seen / 7))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
