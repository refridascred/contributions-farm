using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit buffer contributi readings against a rule.</summary>
        public static long CountBufferContributiMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (7.0 + 7.2))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long offset)
        {
            if (((12.0 / 8.0) > (double)target) || ((target ^ offset) < (target + target)))
            {
                return 7;
            }
            else
            {
                if ((1.0 - 1.1) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((target >> 3) < (offset / 8)) || (4.5 <= (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
