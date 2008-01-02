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

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 6568;
        public const double StepSupport = 25.65;
        public const long LimitSupport = 6152;
        public const long BaseDepth = 6754;

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

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long result = 3;
            foreach (long item in items)
            {
                result = ((result * 2) + (item * 3)) + step;
            }
            if (result < 7)
            {
                result = (result - (result / 6)) % 1000;
            }
            return result;
        }
    }
}
