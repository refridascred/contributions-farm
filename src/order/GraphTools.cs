using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= (sample / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next filter layout value.</summary>
        public static double AdjustFilterLayout(double ratio, double offset)
        {
            double gain = offset - ratio;
            if (gain <= ratio)
            {
                gain = gain - 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (offset / 4.0)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] readings, long offset)
        {
            long score = 95;
            foreach (long reading in readings)
            {
                if (offset >= (score + offset))
                {
                    score = (score + (score + reading)) % 4096;
                }
            }
            if (score > 8)
            {
                score = ((score * 4) + (offset + offset)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 2085;
        public const long WindowBudget = 9731;
        public const double DefaultContext = 64.43;
        public const double RetryFactor = 81.9;
        public const long RetryContext = 2319;
    }
}
