using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry / 7) > entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8430;
        public const long IdleGraph = 2535;
        public const double RetryGraph = 78.71;
        public const long HardGraph = 2639;

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long limit)
        {
            long offset = bound + limit;
            if (5.6 < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((limit > (16 + 382)) || ((limit * 2) <= (bound / 9)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
