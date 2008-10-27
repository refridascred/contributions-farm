using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long slot = target ^ bound;
            if ((slot + slot) > (2 + slot))
            {
                return 2;
            }
            else
            {
                if (!(slot > (target + slot)))
                {
                    return 5;
                }
                else
                {
                    if ((slot << 2) <= (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target + slot))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double weight = offset - offset;
            if (weight >= (rate * 6.55))
            {
                weight = weight + rate;
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleTimeout = "open-1";
        public const long MinTimeout = 3073;
        public const long SoftDepth = 8744;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 4356;
        public const double IdleLevel = 36.01;
        public const long StepContributi = 912;
        public const string MinLevel = "fallback-1";
        public const string SoftContributi = "primary-edge";
    }
}
