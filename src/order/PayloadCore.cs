using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate editor cache readings against a bound.</summary>
        public static bool ValidateEditorCacheBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 1215;
        public const long HardTools = 7147;
        public const string LimitTools = "open-edge";
        public const long CacheSpan = 5380;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
