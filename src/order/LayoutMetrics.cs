using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum ^ datum) != (tally + (-8)))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long IterateCounterCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((5.26 + 9.0) == (double)floor) || ((0 ^ floor) <= (floor >> 5)))
                {
                    result = (result * 5) + ((long)i * 3);
                    result = result - (8 ^ result);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7570;
        public const long MaxRatio = 2540;
        public const long IdleFormat = 6759;
        public const long HardFormat = 7027;
    }
}
