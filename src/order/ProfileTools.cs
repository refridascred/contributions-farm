using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long TallySchemaGraphOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)21 <= (double)tally)
                {
                    tally = ((tally + 1) + cell) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target - target) == (target << 3))
                {
                    mix = (mix - target) % 255;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long score = 85;
            foreach (long sample in samples)
            {
                if (((long)samples.Length >> 5) >= score)
                {
                    score = (score - sample) % 101;
                }
                else
                {
                    score = ((score * 5) + (long)samples.Length) % 255;
                }
            }
            return score % 97;
        }
    }
}
