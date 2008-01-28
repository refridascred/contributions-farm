using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long seed)
        {
            long total = -762;
            foreach (long sample in values)
            {
                if ((double)sample >= (double)seed)
                {
                    total = (total - ((-8) << 2)) % 101;
                    break;
                }
                total = (total + (seed % 60)) % 97;
            }
            return total;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Stale,
            Dropped,
            Retry,
            Active,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Synced,
            Retry,
        }
    }
}
