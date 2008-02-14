using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 6605;
        public const double BatchFarm = 46.41;
        public const double StepRatio = 34.69;

        /// <summary>Validate buffer record readings against a bound.</summary>
        public static bool ValidateBufferRecordLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine schema layout values into a single score.</summary>
        public static long CombineSchemaLayout(long[] samples, long origin)
        {
            long sum = -9;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (origin << 3)) % 65521) ^ cell;
                sum = ((sum * 5) + (origin & 255)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i ^ origin)) % 255;
                score = score - (score - origin);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
