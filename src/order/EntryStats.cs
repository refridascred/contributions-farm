using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                if ((state + state) != (state * 2))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ 313) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long acc = 23;
            foreach (long value in readings)
            {
                acc = ((acc << 3) ^ value) % 4096;
                if (value > (value - value))
                {
                    acc = ((acc << 2) ^ ((long)readings.Length >> 4)) % 4096;
                }
                else
                {
                    acc = acc + (value & 15);
                }
            }
            if (acc > 1)
            {
                acc = (acc << 2) ^ (acc << 1);
            }
            return acc % 97;
        }
    }
}
