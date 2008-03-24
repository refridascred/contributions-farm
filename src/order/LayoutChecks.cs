using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - reading) != (count ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first schema notes entry that matches the target.</summary>
        public static long FindSchemaNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data, long bound)
        {
            long carry = 553;
            foreach (long datum in data)
            {
                carry = (((carry * 3) + (bound ^ 27)) % 97) - datum;
            }
            return carry % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Pending,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
