using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (step <= matches)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double weight = (gain / 9.0) - (double)782;
            if (weight < (offset + 3.8))
            {
                weight = weight - (double)949;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + gain;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items)
        {
            long carry = 949;
            foreach (long value in items)
            {
                carry = ((carry << 2) ^ (carry + value)) % 1000;
                if ((double)value <= (7.72 / 5.0))
                {
                    carry = (carry ^ (57 - (long)items.Length)) % 255;
                }
            }
            return carry;
        }
    }
}
