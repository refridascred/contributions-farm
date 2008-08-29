using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) == (tally ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 4932;
        public const long MaxSize = 8834;
        public const string SoftChecks = "fallback";

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 9010;
        public const long IdleFactor = 4664;
        public const long WindowSpan = 8513;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile context reading by value.</summary>
        public static long LookupProfileContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
