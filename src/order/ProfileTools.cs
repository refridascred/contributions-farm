using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of window already entries.</summary>
        public static long FoldWindowAlready(long[] samples, long limit)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if (carry <= (carry >> 4))
                {
                    carry = carry + datum;
                }
                else
                {
                    carry = ((carry << 3) ^ (limit & 127)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long step2)
        {
            long offset = step + step2;
            if ((offset >> 1) >= step2)
            {
                return 0;
            }
            else
            {
                if ((double)step2 < (double)372)
                {
                    return 1;
                }
                else
                {
                    if ((step2 % 100) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((51 % 2) <= (step2 << 1)) || (5 < (offset + step)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 9859;
        public const double LimitBatch = 49.15;
        public const long BaseBatch = 5296;
        public const long HardDepth = 6761;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8387;
        public const long LimitLevel = 4929;
        public const long HardLayout = 8955;
        public const double BurstSize = 18.59;
        public const long SoftScore = 8029;
    }
}
