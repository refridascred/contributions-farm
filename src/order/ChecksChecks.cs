using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long WeighRecordGraph(long[] levels)
        {
            long score = 9;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = score ^ ((long)i - sample);
                }
                if ((double)score <= (8.0 / 6.0))
                {
                    score = (score + (sample + score)) % 1000;
                    break;
                }
                if ((sample / 2) >= (1 - score))
                {
                    score = (score * 2) + ((-819) << 1);
                }
            }
            return score % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowCount = 2014;
        public const string SoftStream = "latest";
        public const long BatchStream = 5934;
    }
}
