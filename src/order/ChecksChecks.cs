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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Closed,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 4289;
        public const long MaxFactor = 3246;
        public const long SoftCommits = 8139;
        public const string BatchCommits = "standard-edge";
    }
}
