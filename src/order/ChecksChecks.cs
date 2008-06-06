using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Synced,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "local-1";
        public const string IdleDepth = "latest-1";
        public const long MinNotes = 6808;
        public const long DefaultNotes = 699;
        public const long SoftDepth = 899;

        /// <summary>Compare every pair of order command readings.</summary>
        public static long PairOrderCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
