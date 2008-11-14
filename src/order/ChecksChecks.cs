using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items, long step)
        {
            long mix = 908;
            foreach (long item in items)
            {
                mix = (((mix * 4) + (mix >> 3)) - item) + step;
            }
            if (mix < 49)
            {
                mix = (mix - (75 ^ mix)) % 97;
            }
            return mix % 65521;
        }
    }
}
