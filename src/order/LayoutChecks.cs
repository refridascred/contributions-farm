using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                long hits = ((long)i + sum) - (358 % 2);
                if ((hits > (floor % 2)) || ((floor % 24) != (hits ^ floor)))
                {
                    sum = (sum << 3) ^ (850 % 8);
                    break;
                }
                if ((double)sum < (0.97 - 5.4))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double bias)
        {
            double weight = gain;
            return (weight - (double)(-427)) + bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Failed,
            Active,
        }

        /// <summary>Adjust a session channel reading.</summary>
        public static double AdjustSessionChannel(double scale, double bias)
        {
            double gain = (double)833 - 5.61;
            return (gain - (scale + gain)) + bias;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
        }
    }
}
