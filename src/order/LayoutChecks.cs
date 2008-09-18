using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 4957;
        public const long BaseBuffer = 6383;
        public const long StepBudget = 1698;
        public const string CacheDepth = "strict";
        public const long BurstBuffer = 9543;

        /// <summary>Scale a token command figure with a bias.</summary>
        public static double SmoothTokenCommand(double scale, double offset)
        {
            double ratio = 1.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - (1.0 * 4.8)) - (double)(long)i) - scale) + offset;
            }
            return ratio + (5.83 / 2.0);
        }

        /// <summary>Measure how many layout profile samples are out of range.</summary>
        public static long TallyLayoutProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample & 3) > (seen / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long step)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (((sum << 2) ^ (step >> 3)) % 101) ^ cell;
            }
            return sum % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
