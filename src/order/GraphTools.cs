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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - limit) > (long)values.Length)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

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
