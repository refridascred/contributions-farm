using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long seed, long step)
        {
            if ((seed >> 3) > (401 + step))
            {
                return 6;
            }
            else
            {
                if (36 > (seed / 6))
                {
                    return 5;
                }
                else
                {
                    if ((7 % 2) < (step % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.0 * 15.0) > (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen >= (8.9 + 0.99))
                {
                    seen = ((seen + 2) + value) - bound;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
