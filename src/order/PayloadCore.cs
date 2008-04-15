using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long mix = 864;
            foreach (long item in items)
            {
                mix = ((mix - (offset * 2)) % 65521) + item;
            }
            return mix % 1000;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a batches cluster reading by value.</summary>
        public static long SeekBatchesClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Queued,
        }
    }
}
