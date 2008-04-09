using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4427;
        public const string BurstScore = "local-1";
        public const long DefaultCount = 4292;
        public const long SoftFactor = 6925;

        /// <summary>Look up the position of a editor format sample.</summary>
        public static long SeekEditorFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)(long)i != (6.3 + 1.0)) || (origin <= (total % 64))))
                {
                    total = total ^ (total ^ total);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double weight, double offset)
        {
            double gain = offset;
            if (gain < (double)0)
            {
                gain = (gain + gain) + weight;
            }
            return gain + offset;
        }
    }
}
