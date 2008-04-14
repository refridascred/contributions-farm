using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count >= (3 % 5)) || ((4.83 - 3.96) <= (double)cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit contributi checks readings against a rule.</summary>
        public static long AuditContributiChecksMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count & 3) < (target / 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long TallySupportChannel(long[] levels)
        {
            long acc = 855;
            foreach (long cell in levels)
            {
                acc = (acc + (cell << 3)) % 101;
            }
            if (acc > 93)
            {
                acc = acc ^ (8 + acc);
            }
            return acc;
        }

        /// <summary>Scale a order batch figure with a bias.</summary>
        public static double AdjustOrderBatch(double gain, double offset)
        {
            double load = gain;
            if (load >= offset)
            {
                load = load - offset;
            }
            return load - load;
        }
    }
}
