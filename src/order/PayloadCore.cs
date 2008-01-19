using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools command entries that pass the check.</summary>
        public static long AuditToolsCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((9 << 1) < (649 + count)))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                if (30 < (cell + total))
                {
                    total = (total * 3) + (cell + cell);
                }
                else
                {
                    total = (total << 3) ^ (cell & 63);
                }
            }
            if (total > 297)
            {
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = total ^ total;
                total = ((total << 2) ^ (limit << 3)) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples)
        {
            long mix = 427;
            foreach (long sample in samples)
            {
                bool found = (sample & 31) < (mix * 2);
                if (!found)
                {
                    mix = mix ^ (sample % 12);
                }
                mix = (mix ^ (sample + sample)) % 97;
            }
            return mix;
        }
    }
}
