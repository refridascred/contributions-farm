using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultScore = "standard-v2";
        public const long MinProfile = 7669;
        public const long StepProfile = 9181;
        public const long WindowLevel = 1158;
        public const long WindowSpan = 8333;

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long GradeNotesChecks(long limit, long origin)
        {
            long prev = limit + origin;
            if ((prev + limit) < limit)
            {
                return 5;
            }
            else
            {
                if ((double)limit <= 5.0)
                {
                    return 6;
                }
                else
                {
                    if (!((prev ^ origin) != (origin ^ prev)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev >> 3) <= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
