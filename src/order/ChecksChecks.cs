using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Count tools route pairs that satisfy a relation.</summary>
        public static long OverlapToolsRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - cell) > (cell * 4))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
