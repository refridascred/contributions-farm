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

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8489;
        public const double MinQueue = 76.18;
        public const long StepCount = 1059;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Stale,
            Pending,
        }
    }
}
