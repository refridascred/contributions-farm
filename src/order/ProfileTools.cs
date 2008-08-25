using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "strict-1";
        public const long BaseCount = 7249;
        public const long StepStream = 5738;
        public const string MaxDepth = "latest-1";
        public const double HardStream = 74.55;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((cell + cell) > 499) || ((67 - origin) >= (68 >> 1))) && (((cell + origin) <= (seen + 73)) && (seen >= (seen - origin))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long seed, long target)
        {
            if (((double)target >= (2.58 - 15.0)) && ((seed & 15) == (target << 1)))
            {
                return 2;
            }
            else
            {
                if ((seed >> 1) < (seed + 683))
                {
                    return 8;
                }
                else
                {
                    if ((((-96) + target) < seed) && ((target - seed) <= (target ^ 214)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
