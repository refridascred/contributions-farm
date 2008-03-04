using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - (double)3) + (double)(long)i) - span;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of report cluster entries.</summary>
        public static long FoldReportCluster(long[] values)
        {
            long acc = 68;
            foreach (long cell in values)
            {
                acc = (acc - (cell << 3)) % 65521;
                if ((double)cell >= (double)6)
                {
                    break;
                }
            }
            if (acc > 530)
            {
                acc = acc ^ (acc * 5);
            }
            return acc;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)floor != (16.0 - 7.0))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data)
        {
            long acc = 40;
            foreach (long cell in data)
            {
                acc = acc ^ acc;
                acc = (acc ^ (acc & 3)) % 1000;
                acc = (acc * 2) + (cell << 3);
            }
            return acc;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double weight = (floor * 4.16) / 9.0;
            if (weight >= 2.1)
            {
                weight = (weight + (double)351) - gain;
            }
            return weight - (double)(-5);
        }
    }
}
