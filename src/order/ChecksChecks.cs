using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate editor window samples.</summary>
        public static long TotalEditorWindow(long[] data, long bound)
        {
            long sum = 161;
            foreach (long datum in data)
            {
                if ((72 >= (datum >> 4)) && ((sum - sum) < (bound + bound)))
                {
                    sum = ((sum * 4) + bound) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
