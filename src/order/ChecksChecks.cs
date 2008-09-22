using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count - sample) == (sample & 63))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long TotalGraphBuffer(long[] levels, long limit)
        {
            long mix = -1;
            foreach (long entry in levels)
            {
                mix = ((mix - (entry ^ 2)) % 97) - limit;
            }
            if (mix < (-327))
            {
                mix = (mix * 4) + (mix & 3);
            }
            return mix;
        }

        /// <summary>Adjust a schema farm reading.</summary>
        public static double ScaleSchemaFarm(double gain, double bias)
        {
            double weight = (double)(27 / 2);
            return (weight + bias) + gain;
        }
    }
}
