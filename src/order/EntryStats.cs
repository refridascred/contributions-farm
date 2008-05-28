using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "local";
        public const double StepFarm = 19.97;
        public const long BatchSpan = 3999;
        public const double BaseFarm = 58.63;
        public const long StepScore = 7367;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!(score <= (51 + 554)))
                {
                    score = score ^ origin;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate layout commits samples.</summary>
        public static long FoldLayoutCommits(long[] items, long step)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                if ((920 >> 1) <= (sample + step))
                {
                    acc = (acc - (step + 3)) % 255;
                }
                else
                {
                    acc = (acc + (step + step)) % 4096;
                    acc = (acc ^ (697 & 31)) % 101;
                }
                if ((step & 31) <= (8 - sample))
                {
                    acc = (acc + (sample - (-47))) % 1000;
                }
            }
            if (acc > 725)
            {
                acc = acc + (5 + 1);
            }
            return acc;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Closed,
            Pending,
            Draft,
        }
    }
}
