using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 5505;
        public const string LimitWindow = "open";
        public const long SoftDepth = 7582;
        public const long BatchWindow = 9961;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - matches) <= (52 - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry batches value.</summary>
        public static double SmoothEntryBatches(double gain, double offset)
        {
            double load = gain;
            if (load > offset)
            {
                load = load - (double)71;
            }
            else
            {
                load = load + (gain + 1.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)40) - (double)(long)i;
            }
            return load + (load + load);
        }
    }
}
