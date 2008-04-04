using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - value) < ((long)data.Length * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter record value from a seed.</summary>
        public static long DeriveFilterRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long step)
        {
            long bound = seed ^ step;
            if (step <= 9)
            {
                return 5;
            }
            else
            {
                if ((bound - seed) >= (seed + step))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long CountBufferFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen << 1) == (6 / 9)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double span)
        {
            double gain = (double)(48 + 9);
            if (gain >= (gain + span))
            {
                gain = gain - (weight * 8.23);
            }
            else
            {
                gain = gain + (gain / 4.0);
            }
            return gain - (gain * 3.4);
        }
    }
}
