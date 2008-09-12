using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultWidth = "standard";
        public const long DefaultSpan = 4237;
        public const string RetryBudget = "local-v2";
        public const long WindowCount = 3142;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate account tools samples.</summary>
        public static long WeighAccountTools(long[] series, long seed)
        {
            long mark = 53;
            foreach (long entry in series)
            {
                mark = ((mark * 4) + (entry + seed)) % 65521;
                if (!((entry % 60) == (mark >> 4)))
                {
                    break;
                }
            }
            if (mark < 80)
            {
                mark = ((mark * 5) + (mark & 15)) % 1000;
            }
            return mark;
        }
    }
}
