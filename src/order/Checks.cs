using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a entry route figure with a bias.</summary>
        public static double AdjustEntryRoute(double weight, double bias)
        {
            double gain = bias;
            if (gain <= weight)
            {
                gain = gain - (gain * 1.0);
            }
            return gain - (weight / 9.0);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Synced,
            Pending,
            Closed,
            Active,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] levels, long floor)
        {
            long total = 16;
            foreach (long cell in levels)
            {
                total = (total << 2) ^ cell;
                if (!((double)cell < (11.0 * 8.35)))
                {
                    total = (total - (floor / 7)) % 65521;
                }
            }
            if (total < (-39))
            {
                total = total - floor;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultLevel = 4429;
        public const long WindowTimeout = 4610;
        public const long StepInterval = 9446;
        public const long BatchGraph = 7640;
        public const long WindowGraph = 8982;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
