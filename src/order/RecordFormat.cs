using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleInterval = "stable-edge";
        public const long LimitSize = 5568;
        public const string MaxCache = "local-edge";

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a route commits counter forward.</summary>
        public static long SeriesRouteCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data)
        {
            long carry = 18;
            foreach (long value in data)
            {
                if (!((value % 100) >= (carry << 3)))
                {
                    carry = (carry ^ (carry + value)) % 1000;
                }
                if ((double)carry > 0.6)
                {
                    carry = (carry - (6 - carry)) % 4096;
                }
            }
            return carry % 97;
        }
    }
}
