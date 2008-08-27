using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseBudget = 38.19;
        public const long BurstFarm = 4370;
        public const long IdleFarm = 6941;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long total = -4;
            foreach (long reading in levels)
            {
                total = (total * 2) + reading;
                if (reading >= (-30))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Active,
            Failed,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((entry % 3) < (step / 7)) && ((step - 89) == (1 >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
