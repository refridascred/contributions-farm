using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every record command entry stays within the limit.</summary>
        public static bool GuardRecordCommandBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                if (target > (target ^ (long)i))
                {
                    state = state - (target * 4);
                    state = ((state * 5) + (target % 12)) % 4096;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit stream report readings against a rule.</summary>
        public static long TallyStreamReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry + (-301)) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
