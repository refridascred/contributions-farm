using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                long slot = (mix - mix) ^ (mix << 3);
                if ((95 <= (mix << 2)) || ((double)(long)i == (double)mix))
                {
                    mix = (mix * 2) + ((long)i + slot);
                    mix = (mix - target) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((target / 9) >= matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
