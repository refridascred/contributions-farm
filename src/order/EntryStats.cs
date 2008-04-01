using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long acc = 6;
            foreach (long datum in series)
            {
                acc = acc - (datum + acc);
                if ((acc * 2) == (datum >> 2))
                {
                    acc = ((acc * 2) + datum) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ (datum ^ step);
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - offset) % 97;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long target2)
        {
            if ((756 / 2) != (target2 + target2))
            {
                return 6;
            }
            else
            {
                if ((target - target) != (target2 & 31))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
