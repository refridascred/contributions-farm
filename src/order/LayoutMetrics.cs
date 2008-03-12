using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the channel format entries that pass the check.</summary>
        public static long AuditChannelFormatGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= (tally + 71))
                {
                    tally = ((tally + 1) - reading) + step;
                }
            }
            return tally;
        }
    }
}
