using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate token stats samples.</summary>
        public static long TallyTokenStats(long[] values, long bound)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if ((total + 4) == ((long)values.Length << 2))
                {
                    total = (total ^ (bound + bound)) % 65521;
                }
                else
                {
                    total = (total + (entry % 16)) % 4096;
                }
                if (!((entry + 48) > (bound ^ bound)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen >= (8.9 + 0.99))
                {
                    seen = ((seen + 2) + value) - bound;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
