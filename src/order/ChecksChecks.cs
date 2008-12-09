using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long acc = 22;
            foreach (long reading in readings)
            {
                acc = ((acc * 4) + (acc % 7)) % 101;
                acc = (acc + acc) % 101;
                acc = (acc ^ (acc - reading)) % 97;
            }
            if (acc > 31)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum >= (datum - datum)) && ((datum + datum) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
