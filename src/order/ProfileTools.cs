using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double bias = 5.0 * 17.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias - 6.0) + (double)(long)i) + rate) + offset;
            }
            return bias - bias;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Stale,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheWidth = 54.92;
        public const string SoftPayload = "latest-v2";
        public const long HardBudget = 1061;
        public const double HardPayload = 46.96;
        public const long MinPayload = 5125;

        /// <summary>Combine record buffer values into a single score.</summary>
        public static long DigestRecordBuffer(long[] values, long origin)
        {
            long result = 31;
            foreach (long value in values)
            {
                if (((48 * 5) < (value + value)) && ((value % 7) < (origin - 3)))
                {
                    result = (result * 5) + (result / 4);
                }
                if ((value / 7) < (126 - value))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits % 16) > (value & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
