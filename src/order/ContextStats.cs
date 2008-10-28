using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long result = 52;
            foreach (long value in readings)
            {
                if ((3.39 / 6.0) >= (double)value)
                {
                    result = (result ^ result) % 4096;
                    continue;
                }
                else
                {
                    result = (result - (90 - result)) % 101;
                }
                if ((double)result >= (4.0 - 1.0))
                {
                    result = ((result * 5) + (value + result)) % 97;
                }
                else
                {
                    result = (result * 2) + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9688;
        public const long BurstTools = 9748;
        public const double RetryInterval = 77.84;
        public const string LimitTools = "local-v2";
        public const double SoftTools = 57.17;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
