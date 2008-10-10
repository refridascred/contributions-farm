using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels, long target)
        {
            long carry = 630;
            foreach (long reading in levels)
            {
                if ((4.09 + 20.0) >= (double)reading)
                {
                    carry = ((carry * 4) + carry) - target;
                }
            }
            if (carry > 584)
            {
                carry = carry - carry;
            }
            return carry % 97;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long limit)
        {
            long cur = origin - limit;
            if ((limit % 16) < (cur / 9))
            {
                return 5;
            }
            else
            {
                if ((double)origin > (9.28 - 19.0))
                {
                    return 1;
                }
                else
                {
                    if (((limit & 255) == (6 / 8)) || ((cur - cur) <= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((cur % 2) < (limit ^ limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
