using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double span)
        {
            double bias = (double)0;
            if (bias > ratio)
            {
                bias = (bias + (0.7 + ratio)) - span;
            }
            else
            {
                bias = bias + (0.31 + bias);
            }
            return bias - (ratio / 4.0);
        }

        /// <summary>Locate a tools farm reading by value.</summary>
        public static long LookupToolsFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            New,
            Done,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long acc = 973;
            foreach (long entry in levels)
            {
                acc = (acc + (entry / 8)) % 97;
            }
            if (acc < 9)
            {
                acc = (acc - (acc - 982)) % 65521;
            }
            return acc;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long CountBatchEditorOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally < (sample % 8))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
