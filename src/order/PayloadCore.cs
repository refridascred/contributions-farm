using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long target)
        {
            if ((target ^ bound) != (bound - 88))
            {
                return 1;
            }
            else
            {
                if ((bound / 2) >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((target + target) <= target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCount = 58.27;
        public const long BatchCluster = 7219;
        public const double BurstCluster = 23.61;
        public const string WindowCluster = "cached";

        /// <summary>Roll a githubfarm cluster counter forward.</summary>
        public static long IterateGithubfarmCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((double)offset >= (9.07 / 5.0))
                {
                    carry = carry - offset;
                }
                if ((offset > ((-40) & 255)) && (((long)i >> 4) < (-29)))
                {
                    carry = (carry + (offset % 64)) % 101;
                    continue;
                }
                else
                {
                    carry = (carry ^ (666 + offset)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }
    }
}
