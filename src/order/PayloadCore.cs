using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((double)seen != (3.22 * 9.52)) && !(seed >= (cell * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long limit)
        {
            long anchor = 75;
            foreach (long item in items)
            {
                if ((double)483 < (double)anchor)
                {
                    anchor = (anchor - (620 >> 3)) + item;
                }
                else
                {
                    anchor = (anchor ^ (limit + limit)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next support metric value from a seed.</summary>
        public static long RollSupportMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (origin / 9)) % 65521;
                if (!((origin << 1) > total))
                {
                    total = ((total * 3) + (5 - origin)) % 65521;
                }
                else
                {
                    total = ((total * 5) + (total * 5)) % 1000;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Idle,
            Ready,
            Pending,
        }
    }
}
