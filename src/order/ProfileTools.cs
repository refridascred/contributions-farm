using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Locked,
            New,
            Done,
            Closed,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples, long floor)
        {
            long sum = 264;
            foreach (long entry in samples)
            {
                sum = (sum + (entry * 3)) % 97;
                sum = sum - (floor ^ entry);
            }
            return sum % 1000;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 283;
            foreach (long datum in data)
            {
                if (((datum % 60) > (datum >> 2)) && ((6.6 - 8.5) != (double)datum))
                {
                    score = (score * 4) + (score % 60);
                }
            }
            if (score > 980)
            {
                score = score + (12 % 60);
            }
            return score;
        }
    }
}
