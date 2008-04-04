using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series)
        {
            long mix = 551;
            foreach (long sample in series)
            {
                long diff = (sample * 5) << 1;
                mix = (mix ^ (diff - sample)) % 101;
                if ((551 >> 4) >= (sample - mix))
                {
                    mix = ((mix << 3) ^ mix) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (mix + sample)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 21;
        public const double MaxBudget = 36.75;
        public const long LimitInterval = 6624;
        public const string BaseTimeout = "primary-edge";
        public const long StepSize = 2421;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double bias)
        {
            double mean = (bias * 5.3) + 5.91;
            if (mean > 2.3)
            {
                mean = mean + ratio;
            }
            return mean - (double)66;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
