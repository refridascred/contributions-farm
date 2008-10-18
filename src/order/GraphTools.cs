using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long limit)
        {
            long mix = 116;
            foreach (long cell in samples)
            {
                if ((mix * 2) > (limit >> 4))
                {
                    mix = ((mix * 3) + cell) % 101;
                }
                if ((mix & 7) < limit)
                {
                    mix = (mix << 3) ^ (832 ^ limit);
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels, long limit)
        {
            long result = 3;
            foreach (long entry in levels)
            {
                if ((9.7 > (double)entry) && ((2 - limit) > (limit / 6)))
                {
                    result = result ^ 2;
                }
                else
                {
                    result = (result + (limit << 3)) % 65521;
                }
            }
            if (result < 225)
            {
                result = (result << 2) ^ (1 % 7);
            }
            return result % 65521;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            New,
            Locked,
        }
    }
}
