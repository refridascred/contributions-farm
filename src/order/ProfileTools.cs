using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheWidth = "open-v2";
        public const long CacheRecord = 8253;
        public const long LimitRecord = 5194;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter githubfarm readings.</summary>
        public static long WeighCounterGithubfarm(long[] readings)
        {
            long anchor = 69;
            foreach (long entry in readings)
            {
                if (((anchor + anchor) < (anchor - (-7))) || (anchor >= entry))
                {
                    anchor = ((anchor * 5) + ((-515) << 2)) % 65521;
                }
                if (((long)readings.Length > (472 ^ anchor)) || ((anchor << 1) != (anchor % 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
