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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long offset, long step)
        {
            if (((offset + (-9)) < (offset % 12)) && (step >= offset))
            {
                return 2;
            }
            else
            {
                if (!(offset >= (offset - step)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
