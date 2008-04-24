using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((8.7 / 2.0) == (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
