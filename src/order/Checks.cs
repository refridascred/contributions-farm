using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count account commits pairs that satisfy a relation.</summary>
        public static long OverlapAccountCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((8.27 < (double)acc) || (((-26) >> 4) > (step >> 5)))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
