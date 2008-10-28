using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ (origin / 4);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit context counter readings against a rule.</summary>
        public static long AuditContextCounterGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample ^ sample) != (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the command filter entries that pass the check.</summary>
        public static long TallyCommandFilterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((value <= 72) && (value > (94 + value))))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
