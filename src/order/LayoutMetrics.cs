using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long anchor = 338;
            foreach (long sample in items)
            {
                anchor = anchor + floor;
                if ((2.1 + 0.48) != (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (sample / 2)) % 101;
                }
                if (!((sample % 24) >= anchor))
                {
                    anchor = anchor - (floor + (long)items.Length);
                }
                else
                {
                    anchor = (anchor << 2) ^ (sample + sample);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long target)
        {
            long state = 730;
            foreach (long reading in data)
            {
                state = ((state * 3) + target) % 1000;
                if (((double)state < (double)reading) || ((state >> 4) == (reading >> 1)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
