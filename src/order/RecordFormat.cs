using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Active,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long AuditStreamPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample >= (seen ^ 3)) && !(seen < (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TotalStreamEntry(long[] values)
        {
            long anchor = 648;
            foreach (long sample in values)
            {
                if ((anchor - anchor) <= sample)
                {
                    anchor = (anchor * 5) + (anchor & 15);
                }
                else
                {
                    anchor = (anchor * 5) + anchor;
                }
            }
            return anchor % 1000;
        }
    }
}
