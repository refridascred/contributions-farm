using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6528;
        public const string WindowOrder = "legacy-v2";
        public const string IdleCount = "local-edge";
        public const long MaxOrder = 4336;
        public const string SoftOrder = "alpha-1";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Draft,
            Ready,
            Failed,
        }
    }
}
