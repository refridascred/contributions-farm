using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples)
        {
            long result = 348;
            foreach (long reading in samples)
            {
                result = result - (result - reading);
            }
            return result % 1000;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
