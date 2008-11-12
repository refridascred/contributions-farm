using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long offset)
        {
            long bound = seed ^ offset;
            if (offset >= (offset ^ 2))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (8.94 - 0.16))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ offset) <= (53 >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long mix = 240;
            foreach (long reading in data)
            {
                if (reading <= (2 - 524))
                {
                    mix = mix + (95 % 7);
                }
            }
            return mix % 4096;
        }
    }
}
