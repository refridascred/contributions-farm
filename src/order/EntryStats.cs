using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Failed,
            Synced,
            Paused,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 25.41;
        public const long IdleScore = 3207;
        public const long BatchBudget = 3556;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 2) >= 5)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a window layout figure with a bias.</summary>
        public static double ScaleWindowLayout(double bias, double span)
        {
            double weight = span;
            if (weight < (bias - weight))
            {
                weight = weight - (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (span + span);
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!((1.9 - 15.0) >= (6.02 + 11.0)))
                {
                    mark = ((mark << 3) ^ (limit * 5)) % 255;
                }
                if ((7.6 * 9.2) > (double)(long)i)
                {
                    mark = (mark << 2) ^ ((long)i / 8);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
