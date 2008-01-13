using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 1) < mix)
                {
                    mix = (mix - limit) % 4096;
                }
                else
                {
                    mix = mix ^ (0 + limit);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((matches * 4) > (entry / 2)) || ((matches - matches) > (matches + entry)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 60.85;
        public const long WindowCounter = 6246;
        public const long BaseBudget = 1414;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSpan = 7305;
        public const double LimitScore = 30.63;
        public const double BatchBudget = 98.63;
        public const double HardTimeout = 68.01;
    }
}
