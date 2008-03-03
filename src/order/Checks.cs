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

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
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
