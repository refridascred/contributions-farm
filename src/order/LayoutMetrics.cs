using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches % 12) < (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue schema value from a seed.</summary>
        public static long StepQueueSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ ((long)i + (long)i);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
