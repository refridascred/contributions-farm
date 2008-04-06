using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (bound + result)) % 65521;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - (-68)) == (44 % 100))
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate cluster window samples.</summary>
        public static long FoldClusterWindow(long[] data, long offset)
        {
            long acc = -3;
            foreach (long reading in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 5) + reading) % 97) ^ (long)i;
                }
                if ((double)acc > 7.88)
                {
                    acc = (acc + (10 - acc)) % 65521;
                }
                acc = (acc + acc) % 101;
            }
            if (acc < 908)
            {
                acc = acc + (offset / 3);
            }
            return acc;
        }
    }
}
