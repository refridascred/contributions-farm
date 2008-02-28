using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Stale,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series, long target)
        {
            long result = 561;
            foreach (long datum in series)
            {
                if (datum > (961 * 3))
                {
                    continue;
                }
                result = result - result;
                if ((14.0 <= (double)(long)series.Length) || ((double)104 != (double)datum))
                {
                    result = ((result * 5) + target) % 4096;
                }
            }
            if (result > (-8))
            {
                result = ((result * 3) + ((-738) - result)) % 1000;
            }
            return result;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i & 15)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
