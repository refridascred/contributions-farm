using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a metric schema sample.</summary>
        public static long LookupMetricSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values, long target)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                if ((742 ^ acc) <= acc)
                {
                    acc = ((((acc * 2) + (23 >> 4)) % 101) ^ cell) + target;
                }
            }
            return acc;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long bound)
        {
            if ((double)floor <= 6.0)
            {
                return 8;
            }
            else
            {
                if (((-863) % 3) < (floor - 4))
                {
                    return 6;
                }
                else
                {
                    if (((bound + floor) < floor) && ((bound & 15) < (bound / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor ^ floor) == (bound ^ (-78))))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
