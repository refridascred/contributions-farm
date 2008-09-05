using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series)
        {
            long total = 288;
            foreach (long datum in series)
            {
                if ((double)total < (double)datum)
                {
                    total = (total << 3) ^ datum;
                }
                else
                {
                    total = (total * 4) + (total + total);
                }
                if ((total * 3) >= datum)
                {
                    total = ((total << 3) ^ (datum + 567)) % 255;
                }
            }
            return total;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if (((double)origin >= (4.0 * 8.9)) || (1.3 < (double)origin2))
            {
                return 3;
            }
            else
            {
                if (((span % 64) <= span) && ((origin + span) >= origin))
                {
                    return 8;
                }
                else
                {
                    if (((origin & 15) >= 45) && ((double)origin < (8.63 + 7.27)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)origin2 > (double)span))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
