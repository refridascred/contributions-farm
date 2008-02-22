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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if ((double)target > (3.36 + 8.0))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 6311;
        public const long IdleCount = 8463;
        public const double BurstCount = 9.33;
    }
}
