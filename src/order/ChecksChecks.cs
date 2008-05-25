using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a format cache sample.</summary>
        public static long SeekFormatCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph command samples.</summary>
        public static long TotalGraphCommand(long[] series)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if ((anchor + sample) >= anchor)
                {
                    anchor = ((anchor * 3) + (anchor & 31)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
