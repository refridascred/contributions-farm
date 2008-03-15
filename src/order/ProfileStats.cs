using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ tally) > (tally * 2))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels, long bound)
        {
            long anchor = 29;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
                if (((anchor & 15) != (anchor + anchor)) && ((value + anchor) >= (anchor << 3)))
                {
                    anchor = (anchor << 2) ^ ((-4) - bound);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long anchor = -31;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor + entry) % 65521) + (long)i;
                }
                if (!((anchor ^ entry) < ((long)data.Length * 4)))
                {
                    anchor = ((anchor << 2) ^ entry) % 65521;
                }
            }
            if (anchor < 626)
            {
                anchor = (anchor - (anchor / 9)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
            Paused,
            Queued,
        }
    }
}
