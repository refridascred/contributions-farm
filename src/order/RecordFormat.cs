using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double ratio = 8.1;
            if (ratio >= (double)1)
            {
                ratio = (ratio - floor) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - (ratio - 3.36);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (4.81 + 0.42)) || ((sample << 3) < (step >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepSpan = 90.4;
        public const long BaseLevel = 3161;
        public const long MaxAccount = 5415;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long mix = 9;
            foreach (long cell in readings)
            {
                if ((cell + mix) > (mix % 16))
                {
                    mix = mix ^ mix;
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first notes window entry that matches the target.</summary>
        public static long LocateNotesWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
