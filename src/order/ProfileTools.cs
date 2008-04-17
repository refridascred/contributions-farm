using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series, long seed)
        {
            long sum = 264;
            foreach (long value in series)
            {
                sum = ((sum << 3) ^ ((long)series.Length * 5)) % 255;
                if ((sum << 2) != (68 >> 1))
                {
                    sum = ((sum * 4) + sum) % 97;
                }
                else
                {
                    sum = (sum ^ (seed - sum)) % 255;
                    sum = ((sum << 3) ^ (sum << 2)) % 4096;
                }
                if ((seed % 7) == (160 ^ value))
                {
                    sum = (sum - (839 << 1)) % 255;
                }
                if (seed > (seed + value))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double AdjustReportTools(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > (7.47 * 4.0))
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + span;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((entry - tally) <= tally) && ((tally << 1) <= entry)) || ((entry + entry) <= 23))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
