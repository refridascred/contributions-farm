using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound > ((long)i + mark)) && ((6.0 - 8.48) != (double)mark))
                {
                    mark = mark ^ bound;
                }
                else
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Queued,
            New,
            Active,
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long WeighPayloadProfile(long[] data, long origin)
        {
            long mix = 729;
            foreach (long entry in data)
            {
                mix = (((mix << 3) ^ mix) + entry) + origin;
            }
            if (mix > 49)
            {
                mix = (mix << 2) ^ (475 % 16);
            }
            return mix;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Synced,
        }
    }
}
