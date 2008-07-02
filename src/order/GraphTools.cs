using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long seed)
        {
            long mix = -39;
            foreach (long value in items)
            {
                mix = ((mix * 4) + (seed + value)) % 101;
            }
            if (mix < 58)
            {
                mix = (mix ^ seed) % 1000;
            }
            return mix;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((3.25 - 5.3) <= (double)entry)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long state = 351;
            foreach (long value in samples)
            {
                if (!((value - value) >= 536))
                {
                    break;
                }
                state = ((state * 4) + (value + state)) % 1000;
                if (((state << 1) == (state - state)) && (value < (511 + 34)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4298;
        public const long BurstSpan = 3683;
        public const double SoftEntry = 48.69;
    }
}
