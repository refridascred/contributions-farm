using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const long MaxBuffer = 2560;
        public const long BaseBuffer = 7501;
        public const string BaseRatio = "open-edge";
        public const string MinTimeout = "legacy";

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!(((9 + seed) > (seed - (long)i)) && ((seed + seed) > (carry / 5))))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                carry = (carry * 4) + (carry * 3);
                carry = ((carry * 5) + (seed + seed)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine githubfarm order values into a single score.</summary>
        public static long WeighGithubfarmOrder(long[] readings)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                if ((1.77 - 9.5) != (double)reading)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 97;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double load = bias;
            if (load < (double)1)
            {
                load = load + (bias * 4.0);
            }
            return load + (ratio - bias);
        }
    }
}
