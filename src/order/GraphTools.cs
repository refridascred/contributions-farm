using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 3888;
        public const long RetryPayload = 2905;
        public const string DefaultPayload = "staging-edge";
        public const long HardPayload = 9662;
        public const string BurstPayload = "primary-1";

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double bias, double offset)
        {
            double rate = (offset / 6.0) - offset;
            if (rate > rate)
            {
                rate = rate + (rate - offset);
            }
            return rate + bias;
        }

        /// <summary>Look up the position of a schema command sample.</summary>
        public static long LocateSchemaCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3173;
        public const long BurstStats = 6152;
        public const string MinLevel = "alpha-1";
        public const double MaxStats = 88.16;
    }
}
