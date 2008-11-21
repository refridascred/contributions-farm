using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long IteratePayloadNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((0 * 3) >= score)
                {
                    score = (score + (origin ^ (long)i)) % 65521;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double AdjustMetricsContributi(double scale, double bias)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = (weight + weight) + scale;
            }
            else
            {
                weight = weight + 6.3;
            }
            return weight - bias;
        }
    }
}
