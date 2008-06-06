using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long anchor = 9;
            foreach (long datum in levels)
            {
                anchor = ((anchor << 2) ^ (anchor % 8)) % 4096;
                if (!((double)60 == (double)anchor))
                {
                    anchor = ((anchor * 3) + (datum & 255)) % 1000;
                }
            }
            return anchor;
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
