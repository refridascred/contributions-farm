using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items)
        {
            long total = -622;
            foreach (long value in items)
            {
                total = ((total << 2) ^ (value + total)) % 4096;
            }
            return total;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = -81;
            foreach (long datum in levels)
            {
                if ((acc - datum) != (acc * 2))
                {
                    acc = acc ^ datum;
                }
            }
            if (acc > 7)
            {
                acc = acc - (acc & 7);
            }
            return acc;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series)
        {
            long result = 2;
            foreach (long reading in series)
            {
                if (!(((result & 127) == (result + result)) || ((result % 2) > (22 + result))))
                {
                    result = ((result << 3) ^ reading) % 97;
                }
                if (!((double)result > (7.0 * 2.0)))
                {
                    result = (result * 3) + (result + reading);
                }
                result = ((result << 2) ^ result) % 4096;
            }
            if (result < (-901))
            {
                result = ((result << 2) ^ (result << 2)) % 4096;
            }
            return result;
        }

        /// <summary>Derive the next account batches value from a seed.</summary>
        public static long SeriesAccountBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = (total * 3) + 761;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
