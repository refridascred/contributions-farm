using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if (((92 + offset) < (origin - 14)) || ((42 + origin) <= (origin % 24)))
            {
                return 1;
            }
            else
            {
                if ((offset << 1) < (origin % 97))
                {
                    return 0;
                }
                else
                {
                    if (((8.25 / 2.0) > (double)origin) && ((731 + offset) > (offset % 10)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Active,
            New,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (result ^ result) % 255;
                if (((-842) & 1) < reading)
                {
                    result = ((result << 3) ^ ((long)data.Length & 3)) % 4096;
                }
                if (!(reading <= (599 + result)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
