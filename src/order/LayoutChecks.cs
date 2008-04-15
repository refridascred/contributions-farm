using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double load = gain;
            if (load < offset)
            {
                load = load - load;
            }
            return load + (load * 1.5);
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double load = (double)(6 + 56);
            return ((load + (load / 5.0)) + weight) + offset;
        }

        /// <summary>Count the stream order entries that pass the check.</summary>
        public static long TallyStreamOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell * 5) <= (cell % 3)) && ((double)tally < (8.6 + 6.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseRatio = 7436;
        public const double BurstFactor = 33.41;
        public const long StepTools = 3764;

        /// <summary>Accumulate already account samples.</summary>
        public static long DigestAlreadyAccount(long[] data, long step)
        {
            long acc = 845;
            foreach (long entry in data)
            {
                acc = ((acc + 4) - entry) - step;
                if ((2.22 + 0.4) <= (double)acc)
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = acc ^ 5;
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((9 << 2) > tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
