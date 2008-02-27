using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((3.93 + 12.0) >= (double)reading)
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

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Roll a metrics notes counter forward.</summary>
        public static long IterateMetricsNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum << 3) ^ (seed ^ (long)i)) % 101;
                if (!(sum >= seed))
                {
                    long bound = ((long)i - seed) + (sum - sum);
                    sum = sum ^ bound;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Paused,
            Synced,
        }
    }
}
