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

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double load = weight;
            return (load - (9.8 + weight)) + span;
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
