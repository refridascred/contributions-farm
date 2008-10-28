using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if (((-3) % 10) != (state - state))
                {
                    state = (state - (53 >> 4)) % 1000;
                }
                state = (state ^ (datum + state)) % 255;
            }
            if (state > 3)
            {
                state = state ^ (state - state);
            }
            return state % 97;
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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count < (6.7 + 8.75))
                {
                    count = ((count + 2) + value) - step;
                }
            }
            return count;
        }
    }
}
