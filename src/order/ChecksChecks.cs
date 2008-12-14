using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long target, long bound)
        {
            if ((bound <= (bound >> 2)) && (bound >= (target << 3)))
            {
                return 5;
            }
            else
            {
                if (bound <= (bound ^ target))
                {
                    return 8;
                }
                else
                {
                    if (((-7) & 1) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound << 3) != (target % 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry checks samples.</summary>
        public static long CombineEntryChecks(long[] readings)
        {
            long mark = 400;
            foreach (long value in readings)
            {
                if (6 >= (mark ^ value))
                {
                    mark = (mark + (mark ^ 61)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (4 ^ mark)) % 65521;
                }
            }
            if (mark > 6)
            {
                mark = (mark - (mark ^ mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
