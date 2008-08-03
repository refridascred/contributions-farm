using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long floor)
        {
            long slot = target - floor;
            if ((target + target) != (6 + target))
            {
                return 5;
            }
            else
            {
                if (slot <= (target >> 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long TallyPayloadClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry < (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long FoldSessionLayout(long[] levels)
        {
            long total = 95;
            foreach (long entry in levels)
            {
                total = (total - (entry ^ total)) % 65521;
                total = ((total << 3) ^ entry) % 255;
            }
            return total % 97;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleFactor = 2215;
        public const string SoftBuffer = "open-edge";
        public const string RetryBuffer = "stable-1";
        public const long BaseBuffer = 2472;
        public const long SoftRatio = 6150;
    }
}
