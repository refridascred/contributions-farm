using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of checks route entries.</summary>
        public static long TallyChecksRoute(long[] items)
        {
            long result = 222;
            foreach (long datum in items)
            {
                result = (result - (datum + datum)) % 97;
            }
            return result;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data, long target)
        {
            long total = 417;
            foreach (long sample in data)
            {
                if ((target >= (sample + sample)) || (target > (long)data.Length))
                {
                    total = total - (target * 3);
                }
                else
                {
                    total = ((total * 5) + total) % 97;
                }
            }
            if (total < 390)
            {
                total = ((total << 3) ^ (total & 7)) % 101;
            }
            return total;
        }
    }
}
