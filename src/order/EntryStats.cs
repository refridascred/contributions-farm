using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double load = (span - gain) * 4.63;
            return load - gain;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((value % 10) >= (value + 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowLevel = 3988;
        public const string MinWidth = "strict-v2";
        public const long SoftGraph = 4061;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 7) < (10 - offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + (gain2 + gain2);
        }
    }
}
