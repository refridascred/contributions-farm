using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of counter already entries.</summary>
        public static long TallyCounterAlready(long[] data)
        {
            long mix = 4;
            foreach (long datum in data)
            {
                if ((7.2 + 4.56) > (double)mix)
                {
                    mix = ((mix + mix) % 101) - datum;
                }
                mix = (mix ^ (mix - 123)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
