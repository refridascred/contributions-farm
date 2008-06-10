using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Pending,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long total = 9;
            foreach (long entry in values)
            {
                if (!(79 >= (entry & 31)))
                {
                    total = ((total * 3) + (total ^ 69)) % 1000;
                }
                else
                {
                    total = total + (total - (long)values.Length);
                    total = ((total * 4) + (624 + total)) % 255;
                }
                if ((8 % 64) < (88 + total))
                {
                    total = (total + (entry % 24)) % 65521;
                }
            }
            if (total < 7)
            {
                total = ((total * 4) + (total - total)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) > (sample * 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((step & 1) <= (sample << 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
