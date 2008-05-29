using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long MeasureNotesProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((3.8 - 2.5) > (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "staging";
        public const double SoftRatio = 21.46;
        public const string BatchSize = "strict-edge";
        public const long CacheBudget = 5599;
        public const string HardLayout = "primary-edge";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ (result + (long)i)) % 101;
                result = result + ((long)i - 6);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
