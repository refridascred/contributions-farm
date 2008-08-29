using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first buffer editor entry that matches the target.</summary>
        public static long LookupBufferEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route queue reading.</summary>
        public static double ScaleRouteQueue(double weight, double offset)
        {
            double bias = (double)9 / 9.0;
            if (bias >= (double)4)
            {
                bias = bias - (bias * 0.21);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - (bias - offset);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long target)
        {
            if (target > (8 - step))
            {
                return 7;
            }
            else
            {
                if ((3.78 + 8.0) > (double)step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
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
