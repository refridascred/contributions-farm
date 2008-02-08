using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 9938;
        public const string WindowSize = "latest";
        public const long SoftCount = 8332;
        public const long HardRatio = 2217;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 6825;
        public const long WindowNotes = 9837;
        public const double BaseNotes = 27.28;
        public const long LimitNotes = 3157;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
