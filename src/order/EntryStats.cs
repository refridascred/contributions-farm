using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next profile contributi value.</summary>
        public static double SmoothProfileContributi(double bias, double bias2)
        {
            double weight = bias2;
            return (weight + weight) + bias;
        }

        /// <summary>Accumulate queue order samples.</summary>
        public static long DigestQueueOrder(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if ((value - value) != (value + 0))
                {
                    state = (state + (state << 3)) % 4096;
                }
                else
                {
                    state = (state + (value - value)) % 65521;
                }
                if (((998 & 63) <= (value / 5)) && (4.0 < (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 3) + (long)i;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
