using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double offset)
        {
            double weight2 = (offset / 2.0) - weight;
            return weight2 - 8.11;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks payload samples are out of range.</summary>
        public static long CountChecksPayloadHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ cell) >= (matches & 3))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Draft,
            Idle,
        }
    }
}
