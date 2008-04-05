using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels)
        {
            long acc = 406;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length < (double)acc)
                {
                    acc = (acc - (entry << 2)) % 97;
                }
            }
            if (acc < 78)
            {
                acc = (acc + (acc + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "fallback-edge";
        public const double BaseCluster = 11.13;
        public const long BaseInterval = 4669;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
