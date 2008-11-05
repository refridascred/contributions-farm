using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                long delta = (acc ^ step) - (acc * 2);
                if (((delta - acc) == (acc ^ delta)) && (((long)i - step) >= ((long)i << 2)))
                {
                    delta = delta ^ acc;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((double)hits >= 6.9) || ((double)reading >= (2.0 / 3.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool ValidateCounterCommitsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
