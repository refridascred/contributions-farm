using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((bound + bound) <= (matches + 0))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long TallyEditorBatchesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((step / 3) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
