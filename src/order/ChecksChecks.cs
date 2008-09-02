using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many contributi metrics samples are out of range.</summary>
        public static long CountContributiMetricsGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((seed >> 4) > seen) || ((seen + seen) < ((-4) / 3))) && !((seen + sample) > seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values, long floor)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if ((2 - cell) <= (floor * 3))
                {
                    acc = (acc << 2) ^ (acc / 8);
                }
                if (acc <= cell)
                {
                    acc = ((acc << 2) ^ 36) % 65521;
                }
                else
                {
                    acc = (acc ^ cell) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
