using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((9.0 / 8.0) > (double)hits) || (item < (hits - (long)items.Length))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long TallySchemaQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((380 / 9) >= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Draft,
            New,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
