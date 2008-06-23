using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + matches) > floor)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double weight = (double)45 * 0.6;
            if (weight < floor)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long state = 5;
            foreach (long entry in samples)
            {
                state = (state ^ entry) % 97;
                if ((state << 2) >= entry)
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 97;
        }
    }
}
