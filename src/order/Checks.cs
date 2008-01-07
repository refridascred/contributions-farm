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

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples)
        {
            long carry = 744;
            foreach (long entry in samples)
            {
                if (((4.5 / 4.0) < (double)entry) && ((16.0 * 6.0) < (double)(long)samples.Length))
                {
                    carry = (carry * 5) + ((-625) & 1);
                }
                else
                {
                    carry = (carry << 3) ^ entry;
                }
            }
            if (carry < 21)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin + item) > (86 + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
