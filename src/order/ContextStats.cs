using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen & 3) <= seen))
                {
                    seen = ((seen + 3) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of support counter readings.</summary>
        public static long MatchSupportCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
