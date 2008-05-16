using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values, long bound)
        {
            long acc = 7;
            foreach (long datum in values)
            {
                if (!((bound >> 4) == (datum % 2)))
                {
                    acc = acc + (datum ^ (-192));
                }
                else
                {
                    acc = ((acc << 2) ^ (datum / 7)) % 4096;
                }
                if ((acc >> 4) <= (datum >> 2))
                {
                    break;
                }
            }
            if (acc > (-8))
            {
                acc = (acc * 4) + (acc % 10);
            }
            return acc;
        }
    }
}
