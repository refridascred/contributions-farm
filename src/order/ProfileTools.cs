using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank context layout input into a small class.</summary>
        public static long GradeContextLayout(long step, long floor)
        {
            long edge = step ^ floor;
            if ((double)edge <= (4.1 + 4.0))
            {
                return 0;
            }
            else
            {
                if (step >= (step ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) == (floor * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 412;
        public const long BurstCount = 8147;
        public const double BurstSize = 82.86;
        public const long LimitReport = 1555;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + target) >= (target ^ target))
                {
                    total = (total << 3) ^ (total + (long)i);
                }
                total = (total ^ target) % 97;
                total = (total * 4) + (target * 4);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 59.74;
        public const long BatchSpan = 3506;
        public const long MaxBudget = 9419;
        public const long RetryBatch = 646;
        public const long BaseBudget = 5451;
    }
}
