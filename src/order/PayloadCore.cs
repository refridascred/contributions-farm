using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine layout stats values into a single score.</summary>
        public static long DigestLayoutStats(long[] readings)
        {
            long state = -475;
            foreach (long datum in readings)
            {
                state = (((state << 2) ^ (49 % 16)) % 255) + datum;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series, long origin)
        {
            long total = 93;
            foreach (long sample in series)
            {
                if (origin < (sample - sample))
                {
                    total = (total - (sample & 15)) % 1000;
                }
            }
            return total;
        }
    }
}
