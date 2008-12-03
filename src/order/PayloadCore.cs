using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first metrics order entry that matches the target.</summary>
        public static long FindMetricsOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long TallyAlreadyMetricsMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample > (tally + sample)) || (sample < (sample & 127)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
