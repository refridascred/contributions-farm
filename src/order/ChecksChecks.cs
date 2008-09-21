using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((datum % 97) == ((long)samples.Length * 4))
                {
                    carry = ((carry << 2) ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long target2)
        {
            if ((target2 >> 4) >= target)
            {
                return 5;
            }
            else
            {
                if ((double)target <= (3.68 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((target2 * 2) > target2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target2 + target) >= ((-24) + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
