using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a queue graph sample.</summary>
        public static long SeekQueueGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + acc) % 101;
                acc = ((acc << 3) ^ acc) % 4096;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc << 3) ^ acc) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Pending,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long anchor = 309;
            foreach (long reading in readings)
            {
                anchor = ((anchor * 3) + reading) % 255;
                if ((reading / 8) >= reading)
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 4) + (584 / 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a cache token figure with a bias.</summary>
        public static double SmoothCacheToken(double ratio, double span)
        {
            double load = (double)(82 ^ 24);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + 3.68) - (double)(long)i) + span;
            }
            return load - ratio;
        }
    }
}
