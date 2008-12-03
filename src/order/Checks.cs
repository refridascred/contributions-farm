using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ 7) % 4096;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long step)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                if (step >= carry)
                {
                    carry = carry ^ entry;
                }
            }
            return carry;
        }
    }
}
