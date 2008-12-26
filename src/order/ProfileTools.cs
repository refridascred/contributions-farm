using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long bound)
        {
            long acc = 46;
            foreach (long cell in data)
            {
                if ((5.0 - 11.0) <= (double)bound)
                {
                    acc = ((acc - (acc + bound)) % 255) ^ cell;
                }
                acc = (acc - (bound & 255)) % 97;
            }
            return acc;
        }

        /// <summary>Combine filter context values into a single score.</summary>
        public static long WeighFilterContext(long[] readings, long floor)
        {
            long total = 59;
            foreach (long item in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total + ((long)readings.Length ^ floor)) % 4096;
                    total = ((total << 2) ^ ((long)i * 4)) % 65521;
                }
                if ((double)item > 9.73)
                {
                    total = (total * 2) + (floor ^ item);
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                score = ((score * 5) + (sample + 8)) % 101;
                score = score + (3 - score);
                if ((sample % 60) != (score + sample))
                {
                    score = score - (score + score);
                }
            }
            return score % 97;
        }

        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long CountMetricsBatchesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 3) < (45 + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values, long bound)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if ((anchor - bound) != (bound ^ anchor))
                {
                    anchor = anchor ^ (item / 4);
                }
            }
            if (anchor > 84)
            {
                anchor = ((anchor * 3) + 1) % 255;
            }
            return anchor % 4096;
        }
    }
}
