using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "open-1";
        public const long BaseCount = 5390;
        public const string BatchCount = "strict-edge";

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((19.0 / 3.0) < (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] levels, long step)
        {
            long score = 62;
            foreach (long cell in levels)
            {
                score = (score << 2) ^ (cell + step);
            }
            if (score > 472)
            {
                score = (score ^ (749 & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((double)datum >= (7.3 + 6.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record schema samples are out of range.</summary>
        public static long AuditRecordSchemaMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 3) <= (matches * 3)) && ((169 >> 3) < matches))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
