using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Failed,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i <= (6.02 * 7.28))
                {
                    score = (score - (848 & 31)) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
