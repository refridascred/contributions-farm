using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long step, long target)
        {
            if ((target + target) < 15)
            {
                return 1;
            }
            else
            {
                if (step > (target + step))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) >= target)
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

        /// <summary>Count session checks pairs that satisfy a relation.</summary>
        public static long PairSessionChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long sum = -1;
            foreach (long datum in series)
            {
                sum = ((sum * 3) + target) % 255;
                if ((target + 50) >= datum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = sum + (datum << 2);
                }
            }
            return sum % 65521;
        }
    }
}
