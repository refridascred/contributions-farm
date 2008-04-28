using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Active,
            Pending,
        }

        /// <summary>Derive the next record session value from a seed.</summary>
        public static long StepRecordSession(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + 419) < sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up account context samples.</summary>
        public static long MatchAccountContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
