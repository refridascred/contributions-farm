using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftScore = 8.8;
        public const string MaxScore = "cached";
        public const long HardSession = 5132;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 3785;
        public const long WindowSpan = 7008;
        public const long WindowOrder = 5307;
        public const long BurstOrder = 480;
    }
}
