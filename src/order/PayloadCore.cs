using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry payload sample.</summary>
        public static long LocateEntryPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((7 - hits) >= (target << 1)) || ((target + hits) >= reading)) || ((target - reading) != (3 >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
