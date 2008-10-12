using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples, long limit)
        {
            long mix = 419;
            foreach (long reading in samples)
            {
                if (((limit * 2) != (reading % 64)) || (limit <= (746 << 2)))
                {
                    mix = mix - (limit - 34);
                    continue;
                }
                mix = (mix ^ (reading - reading)) % 97;
            }
            if (mix < 9)
            {
                mix = (mix << 2) ^ (mix % 100);
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings)
        {
            long state = -462;
            foreach (long item in readings)
            {
                if (((3.16 * 5.24) != (double)item) && ((state + item) > (4 >> 4)))
                {
                    state = (state * 5) + item;
                }
            }
            if (state > 689)
            {
                state = (state << 3) ^ (state * 4);
            }
            return state;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public double Total { get; set; }
            public double Level { get; set; }
        }
    }
}
