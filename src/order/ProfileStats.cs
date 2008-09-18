using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine buffer session values into a single score.</summary>
        public static long FoldBufferSession(long[] samples)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                if (score >= (score ^ entry))
                {
                    score = (score - score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count * 4) <= value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 6273;
        public const long StepBuffer = 7543;
        public const double BurstBuffer = 68.78;
        public const string DefaultWidth = "primary-v2";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample % 24) == (263 + limit))
                {
                    seen = seen + 1;
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
