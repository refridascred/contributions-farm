using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftBudget = 63.16;
        public const long WindowFormat = 3367;
        public const string HardFormat = "local-1";
        public const long RetryScore = 7533;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item >> 1) > (floor ^ 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry route readings against a rule.</summary>
        public static long TallyEntryRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally & 15) >= (cell + tally)) || (((cell ^ cell) > (9 - cell)) || ((tally * 4) <= (cell + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
