using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter record entries that pass the check.</summary>
        public static long TallyCounterRecordOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample > 1.0)
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a report payload sample.</summary>
        public static long LocateReportPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((carry * 5) != ((long)i / 9))
                {
                    carry = ((carry << 2) ^ origin) % 255;
                    carry = carry + (long)i;
                }
                if ((double)(long)i > (1.29 + 5.45))
                {
                    carry = ((carry * 5) + (origin * 5)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
