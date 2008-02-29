using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long seed, long target)
        {
            long prev = seed - target;
            if (((prev - seed) <= (349 % 100)) || ((17.0 * 2.1) != (double)seed))
            {
                return 4;
            }
            else
            {
                if (((prev << 1) > (seed % 64)) && ((seed + 746) <= (prev ^ seed)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long SortEditorChannel(long seed, long target)
        {
            long edge = seed + target;
            if (!((double)target <= 13.0))
            {
                return 6;
            }
            else
            {
                if ((edge - target) >= (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a tools account counter forward.</summary>
        public static long RollToolsAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score - (score + (long)i)) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
