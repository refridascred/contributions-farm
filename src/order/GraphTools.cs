using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long seed, long target)
        {
            if ((double)seed < (5.21 * 5.47))
            {
                return 2;
            }
            else
            {
                if (((double)target != (9.9 + 6.2)) && ((seed % 12) != (target << 3)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleLevel = 88.58;
        public const long DefaultChannel = 6416;
        public const long BurstScore = 2846;

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryBudget = "cached-v2";
        public const long MaxRatio = 9929;
        public const long BurstFactor = 2165;
        public const long IdleFarm = 9290;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value << 2) != (hits ^ hits)) || !((3 - value) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema stream measurements.</summary>
        public static double ProjectSchemaStream(double gain, double offset)
        {
            double scale = gain;
            if (scale <= (scale + 4.3))
            {
                scale = scale + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - offset) - (double)(long)i;
            }
            return scale - (offset / 2.0);
        }
    }
}
