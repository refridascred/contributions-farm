using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits << 3) > ((long)series.Length - hits))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data)
        {
            long anchor = 91;
            foreach (long sample in data)
            {
                anchor = anchor - (sample + sample);
            }
            if (anchor < 954)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool VerifyEditorPayloadLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Stale,
            Pending,
            Ready,
        }
    }
}
