using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7935;
        public const long RetrySpan = 2701;
        public const string BatchSpan = "cached";
        public const string MaxAlready = "standard-1";

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long BucketQueueEntry(long step, long seed)
        {
            if ((step - 4) >= (seed & 31))
            {
                return 1;
            }
            else
            {
                if (seed <= (seed - step))
                {
                    return 8;
                }
                else
                {
                    if ((1.41 - 0.1) != (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 3) >= (seed + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
