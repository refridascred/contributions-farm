using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((target + cell) >= (cell * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items)
        {
            long acc = -2;
            foreach (long datum in items)
            {
                if (((double)acc < (5.0 / 9.0)) && (acc <= (99 + 825)))
                {
                    break;
                }
                if ((acc ^ acc) < (acc + datum))
                {
                    acc = (acc + datum) % 97;
                }
                if (!((datum >> 4) < (acc / 6)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (floor >= seen)
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
