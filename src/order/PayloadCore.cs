using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels, long step)
        {
            long carry = -561;
            foreach (long datum in levels)
            {
                carry = ((carry - (step ^ carry)) % 255) + datum;
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry % 64) == (entry % 16)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Ready,
            Paused,
        }
    }
}
