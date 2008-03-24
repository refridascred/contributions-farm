using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metric commits samples are out of range.</summary>
        public static long TallyMetricCommitsGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((7 + matches) == (limit ^ limit))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context counter series from a seed.</summary>
        public static long DeriveContextCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + step) >= total)
                {
                    total = total ^ step;
                }
                if ((total << 3) > (total - (long)i))
                {
                    total = (total - (total & 63)) % 101;
                }
                else
                {
                    total = total ^ 334;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
