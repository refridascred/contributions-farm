using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((state + 80) > (state - state))
                {
                    state = (state - (floor + 3)) % 255;
                }
                else
                {
                    state = ((state * 4) + floor) % 255;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long CombineLayoutAccount(long[] series, long seed)
        {
            long state = 23;
            foreach (long entry in series)
            {
                if ((389 << 2) > seed)
                {
                    state = ((state << 3) ^ (seed >> 2)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
