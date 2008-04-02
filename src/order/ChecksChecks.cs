using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Locked,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count <= (14.0 * 3.7))
                {
                    count = ((count + 2) - cell) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
