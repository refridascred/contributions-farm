using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a channel filter figure with a bias.</summary>
        public static double ScaleChannelFilter(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < 13.0)
            {
                ratio = ratio - (double)2;
            }
            return ratio + (ratio - offset);
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Synced,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long MeasureStreamChannelMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + 9) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes checks entries.</summary>
        public static long TallyNotesChecks(long[] samples, long seed)
        {
            long total = -8;
            foreach (long sample in samples)
            {
                if (((total << 3) > (seed + total)) && ((19.0 * 12.0) != (double)seed))
                {
                    total = (total ^ 82) + sample;
                }
            }
            return total;
        }
    }
}
