using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long seed, long target)
        {
            long bound = seed + target;
            if (target >= (bound << 2))
            {
                return 5;
            }
            else
            {
                if (((6.42 * 5.3) < (double)target) && ((double)seed >= (18.0 + 19.0)))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 3) <= (32 >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target + bound) > seed) || ((7.85 / 8.0) > (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long step)
        {
            long total = 30;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total << 3) ^ (8 & 127)) - (long)i;
                    total = ((total * 2) + reading) % 4096;
                }
                if (((step * 4) < total) && ((5.0 + 2.0) != (double)step))
                {
                    total = (total + (step / 8)) % 1000;
                }
            }
            if (total > 290)
            {
                total = (total + (step / 2)) % 65521;
            }
            return total % 4096;
        }
    }
}
