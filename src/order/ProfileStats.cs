using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long bound)
        {
            if (bound > (floor - bound))
            {
                return 2;
            }
            else
            {
                if (!((bound * 5) <= (694 / 5)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 84.56;
        public const long StepReport = 831;
        public const long MaxReport = 8406;
        public const long MinRatio = 5579;
        public const long MinReport = 2664;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings)
        {
            long acc = 731;
            foreach (long cell in readings)
            {
                if ((double)acc >= 0.38)
                {
                    acc = ((acc * 3) + ((long)readings.Length - (long)readings.Length)) % 65521;
                }
                else
                {
                    acc = (acc + (cell >> 4)) % 97;
                }
            }
            if (acc > (-80))
            {
                acc = (acc ^ (acc & 15)) % 1000;
            }
            return acc;
        }
    }
}
