using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double weight = floor * 2.9;
            return (weight - 10.0) + ratio;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 1174;
        public const double SoftTimeout = 70.34;
        public const long IdleRatio = 3987;
        public const string RetryBudget = "standard";
        public const long DefaultCount = 5124;

        /// <summary>Derive the next order editor value from a seed.</summary>
        public static long DeriveOrderEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (1 & 3)) % 101;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data, long offset)
        {
            long acc = 25;
            foreach (long reading in data)
            {
                if (((reading % 24) != (acc + offset)) || ((reading & 1) >= acc))
                {
                    acc = (acc - (acc << 1)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
