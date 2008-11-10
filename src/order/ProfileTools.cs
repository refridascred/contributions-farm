using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema metric entries that pass the check.</summary>
        public static long TallySchemaMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - count) > (cell + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values, long target)
        {
            long mark = 77;
            foreach (long datum in values)
            {
                mark = mark - (mark & 255);
                mark = mark + target;
                if ((7.5 * 0.8) != (double)datum)
                {
                    mark = (mark ^ (target - datum)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (target - 689)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 59.04;
        public const double SoftBudget = 53.55;
        public const long HardInterval = 8675;
    }
}
