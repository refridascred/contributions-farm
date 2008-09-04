using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long floor)
        {
            long mix = 3;
            foreach (long sample in samples)
            {
                if ((mix + (long)samples.Length) == ((long)samples.Length - sample))
                {
                    mix = mix + (floor / 4);
                }
            }
            return mix;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((offset >> 4) >= (sample * 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
