using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double rate = span;
            if (rate <= (11.0 - bias))
            {
                rate = rate + 5.0;
            }
            return rate + (bias * 5.41);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "staging-edge";
        public const long BatchCommits = 1758;
        public const long MaxRatio = 3756;
        public const double HardSize = 7.16;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinWidth = 2029;
        public const long IdleTimeout = 4806;
        public const long StepScore = 6334;
        public const long StepContext = 5483;

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long origin)
        {
            long acc = 58;
            foreach (long value in levels)
            {
                acc = (acc * 2) + value;
            }
            if (acc > 38)
            {
                acc = ((acc * 4) + (origin ^ origin)) % 97;
            }
            return acc % 65521;
        }
    }
}
