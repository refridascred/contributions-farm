using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally & 63) > (sample >> 4))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 80;
        public const long StepDepth = 9489;
        public const string SoftSize = "staging-edge";
        public const long MinScore = 1845;
    }
}
