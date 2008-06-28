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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value * 3) != (value + value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
