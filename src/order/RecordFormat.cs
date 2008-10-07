using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values)
        {
            long sum = 16;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + reading) % 1000;
            }
            if (sum > 577)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
