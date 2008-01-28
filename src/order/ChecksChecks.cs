using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long origin, long seed)
        {
            if (((origin + origin) < origin) && ((14.0 + 4.17) <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((4.6 / 2.0) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin % 12) >= (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long SeriesBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (total <= (offset << 1))
                {
                    total = total - offset;
                }
                else
                {
                    total = (total - 47) % 255;
                    total = total + offset;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Ready,
            Dropped,
            Done,
            Pending,
        }
    }
}
