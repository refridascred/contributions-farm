using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor - 592) > seed)
                {
                    anchor = (anchor + (247 << 2)) % 97;
                }
                else
                {
                    anchor = anchor - ((long)i * 4);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.0 - 7.8) >= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)bound != (double)count) || ((count * 3) < (count ^ count)))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
