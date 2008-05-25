using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = ((result * 5) + (749 + datum)) % 1000;
                if ((double)result == (14.0 * 0.9))
                {
                    result = result ^ (datum / 9);
                }
            }
            if (result > 9)
            {
                result = (result * 4) + result;
            }
            return result;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Pending,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 4132;
        public const double MinSchema = 24.13;
        public const string BatchSchema = "local-edge";
        public const long IdleSchema = 5951;
        public const string DefaultSchema = "latest-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                if ((84 - cell) != (cell + result))
                {
                    result = result ^ (4 % 64);
                }
                else
                {
                    result = (result << 2) ^ result;
                }
                if ((0.4 * 7.8) >= (double)cell)
                {
                    break;
                }
            }
            return result;
        }
    }
}
