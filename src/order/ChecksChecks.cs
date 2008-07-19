using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                if (result <= step)
                {
                    result = (result ^ 630) % 65521;
                }
                result = (result * 3) + (result * 5);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double gain = bias;
            if (gain <= (double)57)
            {
                gain = gain + (double)916;
            }
            else
            {
                gain = gain - (offset / 7.0);
            }
            return gain + (double)50;
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long PairEditorCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
