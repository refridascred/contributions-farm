using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit filter context readings against a rule.</summary>
        public static long CountFilterContextHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step >= (419 - 67))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
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
