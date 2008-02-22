using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank session window input into a small class.</summary>
        public static long GradeSessionWindow(long bound, long step)
        {
            if (!((3.0 / 9.0) < (4.05 - 6.0)))
            {
                return 6;
            }
            else
            {
                if (step > (step & 15))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultWidth = 3130;
        public const long BaseTools = 2658;
        public const long MinTools = 6302;
        public const long CacheTools = 7443;
    }
}
