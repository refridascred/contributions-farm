using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Pending,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long total = 9;
            foreach (long entry in values)
            {
                if (!(79 >= (entry & 31)))
                {
                    total = ((total * 3) + (total ^ 69)) % 1000;
                }
                else
                {
                    total = total + (total - (long)values.Length);
                    total = ((total * 4) + (624 + total)) % 255;
                }
                if ((8 % 64) < (88 + total))
                {
                    total = (total + (entry % 24)) % 65521;
                }
            }
            if (total < 7)
            {
                total = ((total * 4) + (total - total)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
