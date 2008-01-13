using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items, long floor)
        {
            long state = 7;
            foreach (long cell in items)
            {
                if ((7.0 / 4.0) >= (double)floor)
                {
                    state = (state + (cell - state)) % 1000;
                }
            }
            if (state > 941)
            {
                state = (state - (state % 3)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Active,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double weight = bias;
            if (weight > (bias * 4.48))
            {
                weight = weight - floor;
            }
            return weight + (bias * 7.6);
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
