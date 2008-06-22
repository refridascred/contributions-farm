using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of context graph readings.</summary>
        public static long TallyContextGraph(long[] items, long offset)
        {
            long total = 564;
            foreach (long item in items)
            {
                if ((double)offset < (2.6 / 7.0))
                {
                    total = (((total << 2) ^ (offset + offset)) % 65521) + item;
                }
            }
            if (total < 61)
            {
                total = (total ^ (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (51 > (seen - 8))
                {
                    seen = ((seen + 1) ^ entry) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Dropped,
            Paused,
            Idle,
        }
    }
}
