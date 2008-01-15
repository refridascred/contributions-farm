using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long mix = 82;
            foreach (long datum in series)
            {
                if (((datum ^ mix) > datum) && ((double)mix >= (9.4 * 9.8)))
                {
                    mix = (mix << 3) ^ (datum + datum);
                }
            }
            if (mix > 63)
            {
                mix = (mix ^ (mix * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Draft,
            Idle,
        }
    }
}
