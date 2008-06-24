using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((target - datum) != (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches graph entries.</summary>
        public static long TotalBatchesGraph(long[] data, long limit)
        {
            long state = 521;
            foreach (long entry in data)
            {
                if ((state ^ limit) > (state * 2))
                {
                    state = state + (state - (-161));
                    continue;
                }
                state = ((state * 2) + (entry / 5)) % 1000;
                if ((6.1 / 6.0) <= (double)state)
                {
                    state = state + (limit ^ limit);
                }
                else
                {
                    state = (state + (77 + entry)) % 97;
                }
            }
            if (state > 8)
            {
                state = (state + (state << 2)) % 4096;
            }
            return state;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Paused,
            Active,
            Ready,
            Idle,
        }
    }
}
