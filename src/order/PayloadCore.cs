using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits <= (3 - hits))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Dropped,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((0.49 / 3.0) <= (double)hits) && ((hits - reading) <= (286 / 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
