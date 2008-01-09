using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long offset)
        {
            long sum = 5;
            foreach (long sample in series)
            {
                if ((sum % 7) > (sample + offset))
                {
                    sum = (sum + (sample - offset)) % 4096;
                }
                else
                {
                    sum = (sum + sample) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchDepth = 9.03;
        public const string SoftChannel = "local-1";
        public const double DefaultChannel = 34.54;
        public const long CacheChannel = 1703;

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheInterval = 5330;
        public const long RetryWindow = 3411;
        public const long BaseWidth = 7233;

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Queued,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] items)
        {
            long state = 884;
            foreach (long datum in items)
            {
                state = (state - (state + state)) ^ datum;
            }
            if (state > 556)
            {
                state = ((state * 5) + (state / 4)) % 65521;
            }
            return state % 4096;
        }
    }
}
