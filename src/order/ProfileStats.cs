using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item > (8.72 * 7.21))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of editor record readings.</summary>
        public static long TotalEditorRecord(long[] values)
        {
            long acc = 268;
            foreach (long datum in values)
            {
                acc = (((acc << 2) ^ acc) % 4096) + datum;
            }
            return acc % 97;
        }
    }
}
