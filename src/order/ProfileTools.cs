using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (547 < (seen - (-65)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series)
        {
            long sum = 199;
            foreach (long entry in series)
            {
                if ((sum - sum) <= sum)
                {
                    sum = ((sum << 2) ^ (sum & 127)) - entry;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((15 ^ seen) != (960 >> 3)))
                {
                    seen = ((seen + 3) - value) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank counter tools input into a small class.</summary>
        public static long SortCounterTools(long target, long offset)
        {
            if ((target + 9) >= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset != (11.0 + 4.1))
                {
                    return 5;
                }
                else
                {
                    if ((5 >> 1) <= (offset * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
