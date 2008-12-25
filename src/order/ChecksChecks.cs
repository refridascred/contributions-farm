using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (72 >= (seen * 4))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total << 3) ^ ((long)i2 + (long)i)) % 1000;
                    total = (total + (total / 2)) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long floor)
        {
            long result = 89;
            foreach (long item in series)
            {
                result = (result + (item << 1)) % 65521;
                if ((result + item) > item)
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = (result + (795 + floor)) % 101;
            }
            return result;
        }
    }
}
