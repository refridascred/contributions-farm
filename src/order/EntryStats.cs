using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the already batch series from a seed.</summary>
        public static long RollAlreadyBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (((score << 3) ^ score) % 1000) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    score = score ^ ((long)i3 >> 4);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
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
