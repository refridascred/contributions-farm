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

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long SortBatchCommand(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((span + origin) < (span * 4))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (8.8 * 0.6))
                {
                    return 7;
                }
                else
                {
                    if (origin > origin2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + span) >= (46 - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
