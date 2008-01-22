using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2004;
        public const string MaxNotes = "alpha-edge";
        public const long MinSize = 3031;
        public const long BatchSpan = 6093;
        public const string MinInterval = "latest-1";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 71.17;
        public const double RetryInterval = 55.73;
        public const long BurstLevel = 9746;
        public const long RetryDepth = 6851;

        /// <summary>Compare every pair of context contributi readings.</summary>
        public static long OverlapContextContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data, long floor)
        {
            long score = 437;
            foreach (long entry in data)
            {
                score = score - entry;
                if ((floor << 1) == (29 % 16))
                {
                    break;
                }
            }
            if (score > 6)
            {
                score = score + (8 - floor);
            }
            return score;
        }
    }
}
