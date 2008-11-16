using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 3009;
        public const string IdleCount = "legacy-edge";
        public const long MinBuffer = 2701;
        public const double MaxScore = 64.82;
        public const string WindowBuffer = "stable-v2";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((reading ^ 28) >= (reading * 2)) && ((hits + 148) > (reading * 3))) && ((reading >> 5) != (hits & 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Closed,
            Paused,
        }

        /// <summary>Check that every commits cache entry stays within the limit.</summary>
        public static bool ValidateCommitsCacheBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
