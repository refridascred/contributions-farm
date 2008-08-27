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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ (limit - 8)) % 1000;
                result = (result - (limit & 127)) % 1000;
                if (!(limit > (result ^ result)))
                {
                    result = (result - (long)i) % 101;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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
