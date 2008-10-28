using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long score = 7;
            foreach (long value in items)
            {
                if ((value ^ score) < (8 + 761))
                {
                    score = (score ^ (score % 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 35.44;
        public const long IdleLevel = 8933;
        public const long HardWidth = 1314;
        public const double SoftBatch = 27.17;

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double bias)
        {
            double scale = bias;
            return scale + (scale - gain);
        }
    }
}
