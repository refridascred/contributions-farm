using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long TallyProfileEditorMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (9 < tally)
                {
                    tally = ((tally + 2) - reading) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long CountChannelFilterHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((bound / 8) > matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }
    }
}
