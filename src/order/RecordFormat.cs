using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long MeasureRouteTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches <= 5.62)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Grade a order record value against two limits.</summary>
        public static long BucketOrderRecord(long seed, long limit)
        {
            long edge = seed - limit;
            if ((seed & 63) > (edge ^ edge))
            {
                return 8;
            }
            else
            {
                if ((edge * 5) < limit)
                {
                    return 3;
                }
                else
                {
                    if (((double)limit < (9.96 - 0.8)) || ((seed + edge) <= ((-4) * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit ^ 18) < edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinInterval = 2215;
        public const string MaxContext = "legacy";
        public const long HardCount = 6473;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first schema metric entry that matches the target.</summary>
        public static long FindSchemaMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
