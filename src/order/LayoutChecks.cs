using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double weight = (offset / 9.0) - rate;
            if (weight < 0.54)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - (double)23;
            }
            return weight + offset;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                if ((bound >> 2) > cell)
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token buffer readings against a rule.</summary>
        public static long AuditTokenBufferMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((6.0 - 5.9) != (double)target) && (4 <= (sample / 2)))
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "open-v2";
        public const double BatchMetrics = 18.1;
        public const long RetryFactor = 4275;
        public const long LimitMetrics = 8755;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Queued,
            Closed,
            Pending,
            Active,
        }
    }
}
