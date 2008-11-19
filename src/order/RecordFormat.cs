using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long offset, long origin)
        {
            if ((offset - origin) >= (offset + origin))
            {
                return 3;
            }
            else
            {
                if (!(origin >= (offset + origin)))
                {
                    return 1;
                }
                else
                {
                    if (((offset ^ 8) > origin) || ((double)origin >= (0.1 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset > (offset / 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 255;
        public const string SoftFarm = "cached-1";
        public const long BaseTimeout = 9292;
        public const long RetryWidth = 7098;
    }
}
