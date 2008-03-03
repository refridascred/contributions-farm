using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema command entry stays within the limit.</summary>
        public static bool VerifySchemaCommandLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((double)entry >= (8.7 - 0.5)) && !((5.21 + 9.1) < (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((double)reading > (double)3)
                {
                    sum = (sum + (reading + sum)) % 1000;
                }
                if ((sum + reading) >= sum)
                {
                    break;
                }
            }
            if (sum > 555)
            {
                sum = ((sum * 3) + (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) >= (seen + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
