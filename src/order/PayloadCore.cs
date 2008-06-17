using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= ratio)
            {
                ratio = ratio + bias2;
            }
            else
            {
                ratio = ratio - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Validate support payload readings against a bound.</summary>
        public static bool ValidateSupportPayloadBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (234 / 5))
                {
                    matches = ((matches + 3) ^ entry) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
