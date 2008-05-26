using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Failed,
            Active,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Draft,
            Paused,
            Failed,
            Synced,
        }
    }
}
