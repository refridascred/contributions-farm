using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of counter notes entries.</summary>
        public static long CombineCounterNotes(long[] samples, long offset)
        {
            long carry = 2;
            foreach (long datum in samples)
            {
                carry = ((((carry << 3) ^ (carry % 97)) % 101) - datum) - offset;
            }
            return carry % 1000;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Queued,
            Ready,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Rank route batch input into a small class.</summary>
        public static long RankRouteBatch(long limit, long target)
        {
            if ((180 + target) >= limit)
            {
                return 7;
            }
            else
            {
                if (!((1.0 * 17.0) != (double)target))
                {
                    return 4;
                }
                else
                {
                    if (!(limit <= (target - limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (537 > target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Locked,
            Idle,
            Done,
            Stale,
        }
    }
}
