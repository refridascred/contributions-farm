using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 2993;
        public const long HardFarm = 1929;
        public const long CacheFarm = 9815;
        public const string MaxFarm = "primary-edge";
        public const double DefaultLevel = 66.42;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry + 32) >= (entry % 5)) && ((count + count) > entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every notes farm entry stays within the limit.</summary>
        public static bool VerifyNotesFarmRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchFactor = "latest-v2";
        public const long SoftSpan = 1971;
        public const long IdleRatio = 5828;

        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long AuditBufferCommandHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((1.8 / 3.0) <= (double)item)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
