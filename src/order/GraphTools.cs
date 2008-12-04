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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = mix + (long)i;
                mix = mix + (mix * 2);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
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
