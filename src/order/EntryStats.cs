using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long acc = 70;
            foreach (long cell in samples)
            {
                if ((8 - step) == (acc >> 3))
                {
                    acc = (((acc * 2) + (acc & 15)) % 97) ^ cell;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count the tools profile entries that pass the check.</summary>
        public static long CountToolsProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item >= (tally << 2)) || ((1.0 * 5.0) == (double)item)) && ((tally ^ item) <= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up layout order samples.</summary>
        public static long MatchLayoutOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
