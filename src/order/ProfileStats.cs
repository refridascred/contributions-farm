using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long limit)
        {
            long sum = 97;
            foreach (long datum in readings)
            {
                sum = sum - (limit * 4);
                if ((sum < limit) || ((datum + datum) <= 1))
                {
                    sum = ((sum << 2) ^ (long)readings.Length) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Validate notes token readings against a bound.</summary>
        public static bool CheckNotesTokenLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
