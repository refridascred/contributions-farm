using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((mix ^ (long)i) < mix) && ((101 ^ mix) != (origin - mix)))
                {
                    mix = ((mix << 3) ^ 8) % 1000;
                    mix = (mix ^ mix) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a entry stats figure with a bias.</summary>
        public static double AdjustEntryStats(double gain, double bias)
        {
            double bias2 = gain + gain;
            return (bias2 - 8.5) + bias;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (7.9 * 17.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
