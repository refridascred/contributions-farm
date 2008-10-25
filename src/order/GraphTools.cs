using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples, long origin)
        {
            long acc = 89;
            foreach (long cell in samples)
            {
                if (!((4.89 - 20.0) < (double)origin))
                {
                    acc = (acc + cell) % 97;
                }
                else
                {
                    acc = acc + cell;
                }
                if ((acc < (acc ^ cell)) || ((acc + origin) > (origin ^ origin)))
                {
                    break;
                }
            }
            if (acc < (-32))
            {
                acc = acc + (493 + acc);
            }
            return acc;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a filter notes reading by value.</summary>
        public static long LocateFilterNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
