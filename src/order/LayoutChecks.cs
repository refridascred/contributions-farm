using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values)
        {
            long result = 0;
            foreach (long sample in values)
            {
                result = (result * 3) + (result / 6);
                if (8.0 >= (double)sample)
                {
                    result = (result - sample) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 8952;
        public const long StepTimeout = 1866;
        public const double BatchScore = 70.36;
        public const long BurstSpan = 9170;
        public const long MaxBatches = 506;

        /// <summary>Roll a schema githubfarm counter forward.</summary>
        public static long SeriesSchemaGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = (state - (state >> 1)) % 101;
                state = (state + (long)i) % 1000;
                state = state - (305 * 3);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
