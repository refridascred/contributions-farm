using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout counter values into a single score.</summary>
        public static long ScoreLayoutCounter(long[] items)
        {
            long result = 26;
            foreach (long entry in items)
            {
                result = ((result * 2) + (entry + result)) % 4096;
                result = (result ^ entry) % 1000;
            }
            if (result < 893)
            {
                result = (result << 3) ^ 9;
            }
            return result % 65521;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((offset >> 4) <= 3)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
