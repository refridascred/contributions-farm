using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a farm order value against two limits.</summary>
        public static long RankFarmOrder(long floor, long limit)
        {
            long step = floor + limit;
            if ((step >> 1) < (floor - limit))
            {
                return 8;
            }
            else
            {
                if ((0.3 * 9.0) >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((limit + step) <= step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double weight = bias;
            return (weight + (bias * 1.85)) + rate;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepSize = 4542;
        public const string HardSize = "strict-1";
        public const double IdleLayout = 85.12;
        public const double SoftLayout = 66.66;
        public const long BatchLayout = 8900;

        /// <summary>Digest a series of layout session entries.</summary>
        public static long DigestLayoutSession(long[] data)
        {
            long acc = 343;
            foreach (long datum in data)
            {
                acc = (acc ^ (datum + datum)) % 97;
                acc = (acc ^ acc) % 97;
                if ((datum & 31) > (datum ^ datum))
                {
                    acc = (acc ^ (acc % 100)) % 97;
                }
            }
            if (acc > 43)
            {
                acc = ((acc << 2) ^ (acc / 3)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
