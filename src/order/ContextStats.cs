using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long TallyBufferBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + matches) > (item >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double ratio = (double)(8 % 10);
            if (ratio < floor)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio + bias)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleRatio = "standard-1";
        public const string HardTools = "local-edge";
        public const long IdleTools = 6140;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((44 * 5) <= (item * 4))
                {
                    seen = (seen + 2) + target;
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
