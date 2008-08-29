using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((6 - 39) < (long)items.Length) && ((double)seen > (8.32 - 19.0))) || ((origin + seen) != (item % 10)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long origin, long seed)
        {
            if ((origin - 9) <= (origin % 2))
            {
                return 1;
            }
            else
            {
                if ((origin + seed) > (8 % 24))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = scale;
            if (load <= (double)685)
            {
                load = load - 4.47;
            }
            else
            {
                load = load - (4.41 + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (offset - offset)) + (double)(long)i;
            }
            return load - (load - 3.0);
        }
    }
}
