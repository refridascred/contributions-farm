using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Active,
            Draft,
            Done,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long seed)
        {
            long bound2 = bound - seed;
            if ((10.0 / 2.0) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((bound2 + 403) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound2) >= (8 >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepBudget = 5597;
        public const long WindowStats = 4010;
        public const double MinStats = 70.34;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] samples)
        {
            long mix = 251;
            foreach (long datum in samples)
            {
                if ((datum * 5) > (mix & 7))
                {
                    mix = ((mix * 3) + (mix << 2)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ (datum << 3)) % 65521;
                }
            }
            if (mix < 32)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Done,
            New,
            Draft,
        }
    }
}
