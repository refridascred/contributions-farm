using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Ready,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long offset)
        {
            long sum = 2;
            foreach (long datum in levels)
            {
                if (((double)(long)levels.Length != (double)offset) || (datum <= (datum + 4)))
                {
                    sum = ((sum << 3) ^ (datum << 2)) % 255;
                }
                if ((3 - datum) == (datum + datum))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 3) + (offset ^ offset)) % 97;
            }
            return sum % 65521;
        }
    }
}
