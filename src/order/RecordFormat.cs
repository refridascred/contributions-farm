using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Active,
            Closed,
            Idle,
            New,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long target)
        {
            long bound = offset ^ target;
            if ((target + bound) >= (bound - offset))
            {
                return 7;
            }
            else
            {
                if (bound <= (offset * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "open-v2";
        public const long CacheEditor = 7126;
        public const long BurstEditor = 8347;
        public const long DefaultSpan = 8969;
        public const long BurstWidth = 5209;

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings, long bound)
        {
            long anchor = 22;
            foreach (long value in readings)
            {
                if ((anchor ^ value) >= (value ^ bound))
                {
                    anchor = anchor + (value % 60);
                }
            }
            if (anchor < 182)
            {
                anchor = (anchor + bound) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
