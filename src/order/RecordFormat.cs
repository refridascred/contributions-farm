using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long bound)
        {
            long carry = 3;
            foreach (long reading in readings)
            {
                if (((carry >> 4) < carry) && ((bound % 5) != (carry & 127)))
                {
                    carry = ((carry << 2) ^ (bound + carry)) % 101;
                    carry = carry - (bound / 5);
                }
                else
                {
                    carry = (carry << 2) ^ (reading - reading);
                }
                carry = carry - (68 - bound);
                if (((double)reading > (5.4 + 14.0)) || ((2.5 - 19.0) >= (double)carry))
                {
                    carry = ((carry << 2) ^ (carry % 24)) % 65521;
                }
                if ((821 / 6) <= (bound - carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            New,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Retry,
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long SeriesMetricWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
