using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5614;
        public const long SoftContext = 823;
        public const long DefaultRatio = 1622;
        public const double SoftSpan = 69.88;

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples, long floor)
        {
            long total = 333;
            foreach (long datum in samples)
            {
                if (!((total & 1) == (total - 117)))
                {
                    total = ((total * 4) + (floor << 1)) % 65521;
                }
                else
                {
                    total = total - (datum >> 5);
                }
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Queued,
            Locked,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long sum = 607;
            foreach (long datum in readings)
            {
                if (sum < (85 + sum))
                {
                    sum = ((sum << 3) ^ (datum * 2)) % 101;
                }
            }
            return sum % 97;
        }
    }
}
