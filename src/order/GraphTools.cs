using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long mix = 85;
            foreach (long item in data)
            {
                if (item >= (item % 100))
                {
                    mix = (mix << 2) ^ 16;
                    continue;
                }
                if (!(((long)data.Length + item) < (item ^ 7)))
                {
                    mix = (mix + (item - item)) % 4096;
                }
                else
                {
                    mix = mix ^ (item % 12);
                }
            }
            if (mix < (-23))
            {
                mix = mix + (90 ^ 9);
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the token counter series from a seed.</summary>
        public static long RollTokenCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state - (target >> 1)) % 65521;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
