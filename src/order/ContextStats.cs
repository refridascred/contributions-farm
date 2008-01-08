using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Queued,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                mix = (mix ^ datum) % 255;
                mix = ((mix * 2) + (mix & 15)) % 101;
            }
            return mix % 65521;
        }
    }
}
