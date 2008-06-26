using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] items, long floor)
        {
            long sum = 940;
            foreach (long item in items)
            {
                sum = (sum ^ 33) ^ item;
                if (4.66 < (double)floor)
                {
                    sum = sum ^ (floor & 3);
                }
                else
                {
                    sum = (sum * 5) + (floor / 8);
                    sum = (sum + (floor << 1)) % 101;
                }
                if (floor >= (sum & 63))
                {
                    sum = (sum + (floor & 63)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 3203;
        public const long WindowNotes = 7613;
        public const double CacheSpan = 43.34;
        public const long WindowFactor = 5225;
        public const long IdleNotes = 2149;

        /// <summary>Audit session editor readings against a rule.</summary>
        public static long AuditSessionEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (6.0 - 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
