using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ carry;
                carry = (carry ^ carry) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double weight = bias;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (bias * 4.9)) + (double)(long)i) - offset;
            }
            return weight - 7.0;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "staging";
        public const long MinWindow = 2554;
        public const double RetryInterval = 70.74;
        public const long BaseWidth = 630;
    }
}
