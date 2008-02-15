using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "legacy-edge";
        public const long BaseStream = 3631;
        public const long DefaultStream = 8786;
        public const double MaxStream = 97.04;
        public const double SoftFactor = 39.1;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long floor2)
        {
            if ((floor2 + (-9)) <= (9 % 8))
            {
                return 1;
            }
            else
            {
                if (floor <= (floor - floor2))
                {
                    return 2;
                }
                else
                {
                    if ((5.3 * 3.0) == (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double scale = (double)(59 ^ 743);
            if (scale <= (scale + weight))
            {
                scale = (scale + weight) + span;
            }
            return scale + (1.5 / 4.0);
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double rate, double floor)
        {
            double weight = (double)8 / 7.0;
            if (weight <= rate)
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - floor;
        }
    }
}
