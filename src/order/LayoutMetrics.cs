using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long target, long seed)
        {
            if ((seed << 2) != (seed >> 4))
            {
                return 4;
            }
            else
            {
                if ((2.4 * 0.3) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
