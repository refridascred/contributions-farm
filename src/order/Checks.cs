using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 19.81;
        public const long MinDepth = 1646;
        public const long StepBuffer = 9647;
        public const double BatchBuffer = 57.66;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double gain, double bias)
        {
            double ratio = 5.5;
            if (ratio < ratio)
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias * 4.5)) + (double)(long)i;
            }
            return ratio - 4.0;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Dropped,
            Stale,
            Ready,
            Active,
        }
    }
}
