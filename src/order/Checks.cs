using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepRatio = 8339;
        public const long MaxBudget = 3547;
        public const double BurstTimeout = 90.43;

        /// <summary>Digest a series of checks already entries.</summary>
        public static long CombineChecksAlready(long[] samples, long step)
        {
            long mix = 221;
            foreach (long item in samples)
            {
                if ((step - 9) == (mix / 3))
                {
                    mix = (mix - (item / 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (item - step)) % 101;
                }
                if ((0 & 3) >= (item << 3))
                {
                    break;
                }
            }
            if (mix < 57)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every already profile entry stays within the limit.</summary>
        public static bool VerifyAlreadyProfileLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session window readings against a rule.</summary>
        public static long AuditSessionWindowHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(((long)values.Length % 5) >= step))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
