using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data)
        {
            long mark = 700;
            foreach (long reading in data)
            {
                if (reading >= (92 << 1))
                {
                    mark = mark - (mark % 60);
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Queued,
            Retry,
            Draft,
        }
    }
}
