using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long FoldAlreadyStats(long[] values, long target)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                carry = (carry ^ target) ^ entry;
            }
            return carry % 1000;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long bound)
        {
            long offset = origin ^ bound;
            if ((offset << 1) > offset)
            {
                return 1;
            }
            else
            {
                if ((68 ^ origin) != (offset ^ origin))
                {
                    return 5;
                }
                else
                {
                    if (!((-922) >= (origin << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Closed,
            New,
            Queued,
        }
    }
}
