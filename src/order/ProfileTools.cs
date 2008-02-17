using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Pending,
            Active,
            Failed,
            New,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Audit filter contributi readings against a rule.</summary>
        public static long AuditFilterContributiMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits * 3) != (0 + floor))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Closed,
            Done,
        }
    }
}
