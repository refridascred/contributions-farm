using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate queue already readings against a bound.</summary>
        public static bool CheckQueueAlreadyRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((941 << 3) > (tally - datum))
                {
                    tally = (tally + 1) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value > (hits + 43)) || (((value + value) >= (hits << 3)) || (((-69) - value) >= (value % 97))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long offset)
        {
            if (!(offset > (offset * 3)))
            {
                return 3;
            }
            else
            {
                if (offset > (2 / 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
