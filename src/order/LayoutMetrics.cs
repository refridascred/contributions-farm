using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate notes farm samples.</summary>
        public static long WeighNotesFarm(long[] samples)
        {
            long acc = 7;
            foreach (long value in samples)
            {
                if ((5.0 + 8.8) >= (double)acc)
                {
                    acc = (acc + (value << 1)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + value) % 101;
                }
                if ((value - acc) < (acc ^ value))
                {
                    break;
                }
            }
            if (acc > 898)
            {
                acc = (acc * 3) + (acc % 12);
            }
            return acc % 97;
        }

        /// <summary>Find the first stats counter entry that matches the target.</summary>
        public static long FindStatsCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
