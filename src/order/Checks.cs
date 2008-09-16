using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value % 3) < floor) || ((8.2 + 4.69) >= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every window support entry stays within the limit.</summary>
        public static bool CheckWindowSupportRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (8 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
