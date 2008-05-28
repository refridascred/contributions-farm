using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCount = 5505;
        public const string BatchCache = "alpha-edge";
        public const string MaxCache = "strict-v2";
        public const long HardTimeout = 5890;

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double gain, double bias)
        {
            double weight = gain * 8.2;
            if (weight <= bias)
            {
                weight = weight + gain;
            }
            return weight - (double)471;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ seed) % 1000;
                result = (result ^ (long)i) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) <= (count % 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Ready,
            Failed,
            Active,
            Synced,
        }
    }
}
