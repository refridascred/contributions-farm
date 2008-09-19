using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - matches) != (sample ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= (9.77 - 4.2)))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long result = 905;
            foreach (long datum in items)
            {
                if ((2.16 - 4.0) != (double)datum)
                {
                    result = ((result * 3) + ((long)items.Length << 3)) % 101;
                }
                result = result ^ (result << 1);
            }
            return result % 4096;
        }
    }
}
