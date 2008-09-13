using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
