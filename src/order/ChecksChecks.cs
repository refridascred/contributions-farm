using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value & 127) < (value % 10)) || ((double)value <= (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = 259;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (mark / 2)) % 4096) ^ (long)i;
                }
                mark = (mark - item) % 97;
            }
            return mark % 97;
        }
    }
}
