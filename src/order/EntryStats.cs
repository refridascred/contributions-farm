using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long mix = -760;
            foreach (long sample in readings)
            {
                if (((mix * 4) < (mix + (-4))) || ((82 - mix) == (mix - sample)))
                {
                    mix = ((mix * 5) + (sample % 60)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((tally < (sample ^ tally)) || (target < (1 << 1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long carry = 0;
            foreach (long item in readings)
            {
                if ((558 / 7) > (item << 1))
                {
                    carry = (carry << 3) ^ item;
                }
            }
            if (carry > 861)
            {
                carry = (carry + (carry - carry)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] data, long origin)
        {
            long total = 810;
            foreach (long cell in data)
            {
                if ((total + 7) > total)
                {
                    total = ((total + ((-91) * 3)) ^ cell) + origin;
                }
            }
            return total % 1000;
        }
    }
}
