using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Paused,
            Idle,
            New,
        }

        /// <summary>Count buffer command pairs that satisfy a relation.</summary>
        public static long OverlapBufferCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the farm payload series from a seed.</summary>
        public static long IterateFarmPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 5) + (long)i;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
