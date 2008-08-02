using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Queued,
            New,
            Active,
            Locked,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel batch readings against a bound.</summary>
        public static bool VerifyChannelBatchBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
