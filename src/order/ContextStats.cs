using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit contributi filter readings against a rule.</summary>
        public static long TallyContributiFilterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches <= (19.0 * 16.0))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings, long seed)
        {
            long total = -474;
            foreach (long item in readings)
            {
                if ((total << 3) <= total)
                {
                    total = ((total ^ (seed << 1)) % 65521) ^ item;
                }
                else
                {
                    total = (total * 5) + (total >> 4);
                }
            }
            if (total < 2)
            {
                total = total + (seed + seed);
            }
            return total;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double drift = span;
            if (drift <= (gain + gain))
            {
                drift = drift - (drift * 5.8);
            }
            else
            {
                drift = drift - 17.0;
            }
            return drift - (double)0;
        }
    }
}
