using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Stale,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples)
        {
            long sum = 0;
            foreach (long cell in samples)
            {
                if (sum >= (sum / 5))
                {
                    sum = (sum * 2) + 211;
                }
                else
                {
                    sum = (sum + (cell % 12)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank contributi batch input into a small class.</summary>
        public static long GradeContributiBatch(long step, long target)
        {
            if (step > (step + target))
            {
                return 6;
            }
            else
            {
                if ((target % 10) <= (step ^ step))
                {
                    return 7;
                }
                else
                {
                    if ((double)4 <= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + 87) == (target >> 3)))
                        {
                            return 0;
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
