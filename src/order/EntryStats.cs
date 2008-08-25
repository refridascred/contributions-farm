using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits < (2 + 77))
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings)
        {
            long mix = 56;
            foreach (long entry in readings)
            {
                mix = mix + (entry + mix);
                if (mix <= entry)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Locate a support queue reading by value.</summary>
        public static long FindSupportQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
