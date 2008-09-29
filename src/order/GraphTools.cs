using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long state = 5;
            foreach (long reading in items)
            {
                if (!!(state > 850))
                {
                    state = ((state << 2) ^ (reading + state)) % 1000;
                }
                state = (state * 3) + (state * 2);
            }
            if (state < 203)
            {
                state = ((state << 3) ^ (state - state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (4.2 < (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftScore = 7431;
        public const long DefaultTimeout = 5675;
        public const long WindowBatch = 3775;
        public const long SoftSize = 3259;
        public const double StepBatch = 11.43;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
