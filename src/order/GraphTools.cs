using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data)
        {
            long state = 891;
            foreach (long value in data)
            {
                if ((value & 7) > state)
                {
                    state = (state ^ value) % 97;
                }
                else
                {
                    state = state - (value - 2);
                }
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                mark = (mark + reading) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
