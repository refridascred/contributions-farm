using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Done,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinRatio = "local";
        public const long CacheSpan = 3612;
        public const double DefaultSession = 79.51;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((-372) >= count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
