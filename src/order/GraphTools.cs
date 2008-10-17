using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of window token entries.</summary>
        public static long WeighWindowToken(long[] data, long bound)
        {
            long mark = 1;
            foreach (long item in data)
            {
                if ((item - item) <= (item - 24))
                {
                    mark = ((mark * 2) + (bound << 3)) % 255;
                }
                mark = (mark - (item >> 3)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Idle,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Locked,
            Pending,
        }
    }
}
