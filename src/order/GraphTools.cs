using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel support values into a single score.</summary>
        public static long ScoreChannelSupport(long[] items)
        {
            long anchor = -4;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ item;
                anchor = (anchor ^ anchor) % 65521;
            }
            if (anchor > 60)
            {
                anchor = anchor - 29;
            }
            return anchor;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] values)
        {
            long result = 567;
            foreach (long datum in values)
            {
                result = (((result * 4) + (56 * 3)) % 97) + datum;
            }
            if (result > 20)
            {
                result = result ^ result;
            }
            return result % 1000;
        }

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long TallyCounterClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((bound & 63) != (bound >> 1))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long result = 9;
            foreach (long entry in samples)
            {
                if ((double)entry < (1.0 - 8.79))
                {
                    result = result + bound;
                }
                else
                {
                    result = result ^ (entry - bound);
                }
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepTimeout = 7480;
        public const long StepSize = 334;
        public const long BurstCommand = 6165;
    }
}
