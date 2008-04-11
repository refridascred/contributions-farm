using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a entry cache reading by value.</summary>
        public static long LocateEntryCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Blend two session metrics measurements.</summary>
        public static double SmoothSessionMetrics(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 < (ratio * 7.65))
            {
                ratio2 = (ratio2 + (double)877) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio2 * 14.0)) - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long acc = 394;
            foreach (long sample in readings)
            {
                if (((sample % 2) == (811 + acc)) && ((acc % 24) >= (sample * 4)))
                {
                    acc = acc - (acc + sample);
                }
                else
                {
                    acc = (acc + (sample << 2)) % 97;
                }
            }
            return acc;
        }
    }
}
