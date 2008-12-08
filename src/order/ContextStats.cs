using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate route tools readings against a bound.</summary>
        public static bool ValidateRouteToolsBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings, long seed)
        {
            long score = 408;
            foreach (long sample in readings)
            {
                if (!((seed << 3) <= sample))
                {
                    score = (score - (seed ^ seed)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many schema checks samples are out of range.</summary>
        public static long CountSchemaChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((cell >= (tally * 2)) || ((double)cell <= (17.0 - 8.99))) || !(tally <= (tally / 6)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
