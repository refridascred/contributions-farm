using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((7.3 + 0.2) <= (double)acc)
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Compare every pair of format report readings.</summary>
        public static long CompareFormatReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double weight = span + span;
            if (weight > 1.91)
            {
                weight = weight + (span / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits >> 3) <= (cell - target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
