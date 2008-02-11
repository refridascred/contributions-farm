using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long floor)
        {
            if ((target ^ target) >= (6 % 64))
            {
                return 8;
            }
            else
            {
                if ((floor - target) <= floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 2) ^ (bound / 3)) % 101;
                if ((double)bound >= 9.71)
                {
                    acc = ((acc * 4) + (long)i) % 97;
                }
                if ((double)bound >= (9.75 / 2.0))
                {
                    acc = ((acc * 5) + (acc - bound)) % 4096;
                    acc = acc + bound;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Dropped,
            Failed,
            Done,
            Ready,
        }
    }
}
