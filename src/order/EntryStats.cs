using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step / 7) >= (long)i)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Synced,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Paused,
            Stale,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
