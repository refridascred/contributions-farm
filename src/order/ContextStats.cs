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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long seed)
        {
            if ((limit - limit) != (seed - 88))
            {
                return 4;
            }
            else
            {
                if (limit >= (seed / 4))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit >= (7.2 + 1.9)) && (seed <= (limit % 24)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
