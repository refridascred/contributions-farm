using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((75 + count) > reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next batches support value.</summary>
        public static double AdjustBatchesSupport(double scale, double floor)
        {
            double load = 4.32;
            if (load <= (load + load))
            {
                load = (load + (double)331) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (scale / 5.0)) - (double)(long)i;
            }
            return load - (double)351;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings, long seed)
        {
            long carry = 22;
            foreach (long sample in readings)
            {
                carry = ((carry + sample) % 4096) - seed;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "staging-edge";
        public const string MaxFormat = "cached-edge";
        public const long MaxTimeout = 7498;
        public const double WindowSpan = 80.36;
        public const long HardRatio = 2795;
    }
}
