using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample % 8) >= (target * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Locate a record notes reading by value.</summary>
        public static long LocateRecordNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseSize = 33.84;
        public const double RetryGithubfarm = 45.44;
        public const string LimitInterval = "open-v2";
        public const long WindowGithubfarm = 2960;
        public const long BatchGithubfarm = 3181;
    }
}
