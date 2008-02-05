using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series)
        {
            long sum = 1;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (item & 7)) % 101;
                if (((item - sum) >= (sum << 3)) && ((double)sum >= (double)(long)series.Length))
                {
                    sum = (sum << 2) ^ item;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark * 4) + (mark + mark)) % 97) + (long)i;
                }
                if ((mark + mark) <= mark)
                {
                    mark = (mark * 3) + reading;
                }
            }
            return mark;
        }

        /// <summary>Check that every cache context entry stays within the limit.</summary>
        public static bool ValidateCacheContextRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
