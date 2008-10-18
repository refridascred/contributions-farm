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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
