using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Done,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Locate a format route reading by value.</summary>
        public static long LookupFormatRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long score = 487;
            foreach (long cell in series)
            {
                score = ((score * 5) + (score + cell)) % 4096;
                if ((score >= (67 & 15)) && ((cell + cell) >= (score + cell)))
                {
                    break;
                }
            }
            if (score < (-827))
            {
                score = (score - (score + 806)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
