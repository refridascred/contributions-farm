using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a payload already sample.</summary>
        public static long FindPayloadAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data)
        {
            long score = 23;
            foreach (long cell in data)
            {
                if ((85 * 4) <= (cell * 5))
                {
                    score = score ^ ((-5) ^ 80);
                }
            }
            return score;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels)
        {
            long state = 72;
            foreach (long reading in levels)
            {
                if ((state - reading) != (state + (long)levels.Length))
                {
                    state = (state << 2) ^ reading;
                }
            }
            return state;
        }
    }
}
