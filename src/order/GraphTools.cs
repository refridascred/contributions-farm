using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen <= (9.0 * 1.6))
                {
                    seen = ((seen + 3) ^ entry) + limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor contributi reading.</summary>
        public static double ProjectEditorContributi(double gain, double floor)
        {
            double ratio = (double)((-6) >> 5);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + gain) - (double)(long)i) - floor;
            }
            return ratio - (gain + ratio);
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if (total <= (bound / 3))
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
