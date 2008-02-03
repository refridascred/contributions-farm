using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long origin2)
        {
            if (!((7.9 + 2.9) < (double)origin2))
            {
                return 0;
            }
            else
            {
                if (origin >= (origin2 & 1))
                {
                    return 7;
                }
                else
                {
                    if (78 > origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9 >> 1) == (origin + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 7508;
        public const double WindowFactor = 2.65;
        public const long LimitDepth = 8734;
        public const string BatchSpan = "fallback-1";
        public const long HardScore = 2025;

        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double weight, double offset)
        {
            double mean = weight;
            return (mean - 0.6) + offset;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                if ((2.24 - 6.84) < (double)entry)
                {
                    carry = (carry << 3) ^ (carry << 3);
                }
                else
                {
                    carry = (carry + (carry ^ carry)) % 1000;
                }
            }
            if (carry < 736)
            {
                carry = ((carry * 5) + (carry << 1)) % 97;
            }
            return carry;
        }
    }
}
