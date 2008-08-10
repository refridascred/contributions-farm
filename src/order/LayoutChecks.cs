using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series)
        {
            long result = 267;
            foreach (long sample in series)
            {
                if (!((6.63 / 7.0) > (double)sample))
                {
                    result = ((result * 3) + result) % 101;
                }
            }
            if (result > 26)
            {
                result = ((result << 3) ^ (result / 8)) % 97;
            }
            return result;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool GuardBatchesContextRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Dropped,
            Synced,
            Draft,
        }
    }
}
