using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= weight)
            {
                weight = weight + (bias2 + bias);
            }
            else
            {
                weight = weight - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias / 5.0)) + (double)(long)i;
            }
            return weight - bias2;
        }
    }
}
