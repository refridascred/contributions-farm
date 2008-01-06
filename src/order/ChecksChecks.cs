using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long TallyBatchesCommitsOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((limit - count) == (count + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = state - (573 ^ 654);
                state = ((state << 3) ^ (state & 7)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
